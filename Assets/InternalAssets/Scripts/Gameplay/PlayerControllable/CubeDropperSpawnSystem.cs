using UnityEngine;

public class CubeDropperSpawnSystem : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;
    [SerializeField] private CubeGridField _cubeGridField;
    private int _MaxRandomID;

    [SerializeField] private SpriteRenderer[] _stackPrewiew;
    [SerializeField] private CubeSpritesPack _cubeSpritesPack;

    private int[] _cubeIDStack = new int[4];

    private int[,] _gridFields => _cubeGridField.GridField.Fields;
    private const int _topY = 0;



    private void OnValidate()
    {
        _cubeGridField ??= FindObjectOfType<CubeGridField>();
    }

    private void OnEnable()
    {
        CubeDropperMovementSystem.OnNewDotSelected += SpawnCubeFromStack;
    }

    private void OnDisable()
    {
        CubeDropperMovementSystem.OnNewDotSelected -= SpawnCubeFromStack;
    }

    private void Start()
    {
        _cubeSpritesPack = GameManager.LevelConfig.CubeSpritesPack;
        _MaxRandomID = GameManager.LevelConfig.CubeSpritesPack.CubeSprites.Length;

        StartCoroutine(SpawnCubeRopesByTime());
        FillStack();
        
    }

    private void SpawnCube(int GridXPoint, int CubeID, bool IsStackCorrect)
    {
        Vector2 spawnPosition = new Vector2(_cubeGridField.GridField.ConvertGridPointToWorldPoint(GridXPoint, _topY).x, transform.position.y);
        Cube NewCube = Instantiate(_cubePrefab, spawnPosition, Quaternion.identity);

        
        NewCube.Init(_cubeGridField.GridField, GridXPoint, _topY , CubeID, true);
    }

    private void SpawnCubeFromStack(int GridXPoint)
    {
        if (_cubeGridField.GridField.Fields[GridXPoint, 0] != 0) return;

        SpawnCube(GridXPoint , _cubeIDStack[3], true);
        UpdateStack();
    }

    private Cube SpawnCube(int GridXPoint, int GridYPoint, int CubeID)
    {
        Vector2 spawnPosition = _cubeGridField.GridField.ConvertGridPointToWorldPoint(GridXPoint, GridYPoint);
        Cube NewCube = Instantiate(_cubePrefab, spawnPosition, Quaternion.identity);

     

        NewCube.Init(_cubeGridField.GridField, GridXPoint, GridYPoint, CubeID, false);
        return NewCube;
    }

    [ContextMenu("ShiftValuesUp")]
    public void SpawnCubesRope()
    {
        _cubeGridField.ShiftValuesUpAndFillBottom(_MaxRandomID);

        foreach (Cube item in FindObjectsOfType<Cube>())
        {
            if (!item.IsInFallStage) item.SmoothGoUp();
        }

        int j = _gridFields.GetLength(1) - 1;
        for (int i = 0; i < _gridFields.GetLength(0); i++)
        {
            Cube item = SpawnCube(i, j, _gridFields[i, j]);
            item.transform.position -= Vector3.up;
            item.SmoothGotoFix();
        }
    }

    public System.Collections.IEnumerator SpawnCubeRopesByTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(GameManager.LevelConfig.ShiftValuesPeriod);

            if (!Settings.GameIsPaused)
            {
                while (!GameManager.GameCanPullNewCubes)
                {
                    yield return new WaitForEndOfFrame();
                }
                SpawnCubesRope();
            }
        }
    }
    #region StackMethods
    private void UpdateStack()
    {
        _cubeIDStack[3] = _cubeIDStack[2];
        _cubeIDStack[2] = _cubeIDStack[1];
        _cubeIDStack[1] = _cubeIDStack[0];
        _cubeIDStack[0] = Random.Range(1, _MaxRandomID);
    }

    private void FillStack()
    {
        for (int i = 0; i < _cubeIDStack.Length; i++)
        {
            _cubeIDStack[i] = Random.Range(1, _MaxRandomID);
        }
        SyncViewWithStack();
    }
    #endregion
    public void SyncViewWithStack()
    {
        for (int i = 0; i < _cubeIDStack.Length; i++)
        {
            _stackPrewiew[i].sprite = _cubeSpritesPack.CubeSprites[_cubeIDStack[i]];
        }
    }
}
