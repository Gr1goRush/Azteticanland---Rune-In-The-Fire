using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    public static event System.Action OnCubePlaced;
    //public static event System.Action OnFallComplete;
    public static event System.Action OnReachTop;
    public static event System.Action<int> OnTouchAxe;
    [Header("CubeStats")]
    [SerializeField] private CubeSpritesPack _cubeSpritesPack;

    [Space(30f)]
    [SerializeField] private int _cubeID;
    private GridArray _grid;
    private int _myGridX;
    private bool _isInFallStage;

    public int _myGridY = 0;
    private Vector2 _myPosition => new Vector2(transform.position.x, transform.position.y);
    public int CubeID => _cubeID;

    public float FallSpeed = 15f;
    public bool IsInFallStage => _isInFallStage;

    [SerializeField, HideInInspector] private SpriteRenderer _spriteRenderer;

    [Header("Axe")]
    [SerializeField] private Sprite _AxeSprite;

    [Header("Audios")]
    [SerializeField] private AudioClip _fallSound;
    [SerializeField] private AudioClip _axeSound;

    [Header("Animations")]
    [SerializeField] private Animator _animator;

    [SerializeField] private Sprite[] _axeAnimList;

    private void OnValidate()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator ??= GetComponent<Animator>();
    }

    private void OnEnable()
    {
        GridOperator.OnCubeDestroyed += CheckForDestroy;
        GridOperator.OnThreeFinded += OnOperatorFindMe;
        Cube.OnTouchAxe += GetDestroyedByAxe;
    }

    private void OnDisable()
    {
        GridOperator.OnCubeDestroyed -= CheckForDestroy;
        GridOperator.OnThreeFinded -= OnOperatorFindMe;
        Cube.OnTouchAxe -= GetDestroyedByAxe;
    }

    public void Init(GridArray Grid, int GridX, int GridY, int CubeID, bool InstantilateByPlayer)
    {
        _cubeSpritesPack = GameManager.LevelConfig.CubeSpritesPack;
        FallSpeed = GameManager.LevelConfig.CubeFallSpeed;

        _cubeID = CubeID;
        if (_cubeID < _cubeSpritesPack.CubeSprites.Length)
        {
            _spriteRenderer.sprite = _cubeSpritesPack.CubeSprites[_cubeID];
            
        }
        else
        {
            StartCoroutine(PlayAxeAnim());
            _spriteRenderer.sprite = _AxeSprite;
        }


        _grid = Grid;
        _myGridX = GridX;
        _myGridY = GridY;

        if (!InstantilateByPlayer) return;
        StartCoroutine(FallUntilReachOccupiedDot());
    }

    private IEnumerator FallUntilReachOccupiedDot()
    {
        _isInFallStage = true;
        int travelIterations = _myGridY;
        int YLength = _grid.Fields.GetLength(1);
     
        for (int i = _myGridY; i <= YLength; i++)
        {
            Vector2 Position = _grid.ConvertGridPointToWorldPoint(_myGridX, i);

            Vector3 CalcPosition = transform.position;
            while (_myPosition.y != Position.y)
            {
                if (!Settings.GameIsPaused)
                {
                    CalcPosition -= Vector3.up * FallSpeed * Time.deltaTime;
                    transform.position = CalcPosition;

                    if (CalcPosition.y < Position.y)
                    {
                        transform.position = Position;
                    }
                    GameManager.SetPullNewCubesAbilityState(false);
                }
                yield return new WaitForEndOfFrame();
            }

            travelIterations += 1;

            if (i + 1 >= YLength || _grid.Fields[_myGridX, i + 1] != 0) break;
        }

        GameManager.SetPullNewCubesAbilityState(true);

        _grid.SetIDtoGridPoint(CubeID, _myGridX, travelIterations - 1);
        _myGridY = travelIterations - 1;
        OnCubePlaced?.Invoke();
        _isInFallStage = false;
        if (_myGridY + 1 < _grid.Fields.GetLength(1))
        {
            if (_grid.Fields[_myGridX, _myGridY + 1] == 999)
            {
                AudioManager.instance.PlayClip(_axeSound);
                OnTouchAxe?.Invoke(_myGridY + 1);
                DeviceHelper.PlayVibration();
            }
        }

        AudioManager.instance.PlayClip(_fallSound);
    }

    #region UnconstaintedMovement
    public void SmoothGotoFix()
    {
        SmoothGoTo(_grid.ConvertGridPointToWorldPoint(_myGridX, _myGridY));
    }
    public void SmoothGoUp()
    {
        if (_myGridY - 1 < 0) { OnReachTop?.Invoke(); return; }
        _myGridY--;

        SmoothGoTo(_grid.ConvertGridPointToWorldPoint(_myGridX, _myGridY));
    }
    public void SmoothGoTo(Vector2 Position)
    {
        StartCoroutine(SmoothGoto_Routine(Position));
    }
    public IEnumerator SmoothGoto_Routine(Vector2 Position)
    {
        _isInFallStage = true;
        while (_myPosition != Position)
        {
            if (!Settings.GameIsPaused)
            {
                transform.position = Vector3.Lerp(transform.position, Position, 0.3f);
                yield return new WaitForEndOfFrame();
            }
        }
        _isInFallStage = false;
    }

    #endregion
    private void Update()
    {
        if (!_isInFallStage && !Settings.GameIsPaused)
        {
            if (_myGridY + 1 < _grid.Fields.GetLength(1))
            {
                if (!_grid.PointContainsID(_myGridX, _myGridY + 1))
                {
                    _grid.SetIDtoGridPoint(0, _myGridX, _myGridY);
                    StartCoroutine(FallUntilReachOccupiedDot());
                }
            }
        }
    }

    public void CheckForDestroy(Vector2 CubeCoord1, Vector2 CubeCoord2, Vector2 CubeCoord3)
    {
        if (CubeCoord1 == _myPosition || CubeCoord2 == _myPosition || CubeCoord3 == _myPosition)
        {
            Destroy(gameObject);
        }

    }

    [ContextMenu("Debug_Destroy")]
    public void DebugDestroy()
    {
        _grid.Fields[_myGridX, _myGridY] = 0;
        Destroy(gameObject);
    }

    public void GetDestroyedByAxe(int YID)
    {
        if (YID == _myGridY)
        {
            _animator.enabled = true;
            _animator.Play("BeforeDestroy");
            Invoke("DestroySelf", 1);
            GameManager.SetPullNewCubesAbilityState(false);
        }
    }

    private void DestroySelf()
    {
        if (Settings.GameIsPaused)
        {
            Invoke("DestroySelf", Time.deltaTime);
            return;
        }
        Destroy(gameObject);
        _grid.Fields[_myGridX, _myGridY] = 0;
        GameManager.SetPullNewCubesAbilityState(true);
    }

    public void OnOperatorFindMe(Vector2 CubeCoord1, Vector2 CubeCoord2, Vector2 CubeCoord3)
    {
        if (CubeCoord1 == _myPosition || CubeCoord2 == _myPosition || CubeCoord3 == _myPosition)
        {
            _animator.Play("BeforeDestroy");
        }

    }

    private IEnumerator PlayAxeAnim()
    {
        transform.localScale -= Vector3.one;
        while (true)
        {
            for (int i = 0; i < _axeAnimList.Length; i++)
            {
                _spriteRenderer.sprite = _axeAnimList[i];
                yield return new WaitForSeconds(Time.deltaTime * 4);
            }
            for (int i = _axeAnimList.Length - 1; i >= 0; i--)
            {
                _spriteRenderer.sprite = _axeAnimList[i];
                yield return new WaitForSeconds(Time.deltaTime * 4);
            }
        }
    }
}
