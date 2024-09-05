using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UnityEvent OnGameLost;
    public UnityEvent OnGameWin;
    public UnityEvent OnEndlessLevelLoad;

    [SerializeField] private LevelConfig _defaultLevelConfig;
    public static LevelConfig LevelConfig;

    [SerializeField] private Text _speedText;
    [SerializeField] private Text _levelText;
    [SerializeField] private Text[] _winReviewTextPanels;

    private int[] _winOperatorArray;
    private int _completedComboCount;

    private int _startGetted = 0;

    private float _timeSpended;

    [Header("Score")]
    private int _score;
    [SerializeField] private Text[] _scoreRewTexts;

    [Header("StarsRef")]
    [SerializeField] private GameObject[] _stars; 

    private void OnEnable()
    {
        Cube.OnReachTop += GameLost;
        GridOperator.OnThreeColected += UpdateCounter;
    }

    private void OnDisable()
    {
        Cube.OnReachTop -= GameLost;
        GridOperator.OnThreeColected -= UpdateCounter;
    }

    private void Awake()
    {
        instance = this;
        Settings.GameIsPaused = false;

        LevelConfig ??= _defaultLevelConfig;
        _score = 0;

        _speedText.text = LevelConfig.CubeFallSpeed.ToString();
        _levelText.text = LevelConfig.LevelID.ToString();

        if (LevelConfig.IsInfinity)
        {
            OnEndlessLevelLoad?.Invoke();
        }
    }

    private void Start()
    {
        CreateCounterForWin();
        UpdateCounterView();
    }

    private void Update()
    {
        _timeSpended++;
    }

    public void GiveStarForTime()
    {
        if (_timeSpended < LevelConfig.TimeToGetStar)
        {
            GiveStar();
        }
    }

    public void SetStarsOnLevel()
    {
        PlayerPrefs.SetInt(TokenHelper.StartKeyPart + LevelConfig.LevelID.ToString(), _startGetted);
    }

    public void GiveStar()
    {
        _startGetted++;
    }

    public void CreateCounterForWin()
    {
        _winOperatorArray = new int[LevelConfig.CubeGoal.Length];
    }

    public void UpdateCounter(int ID)
    {
        if (LevelConfig.IsInfinity) return;

        if (_winOperatorArray[ID] + 1 < LevelConfig.CubeGoal[ID])
        {
            _winOperatorArray[ID]++;
        }
        else if (_winOperatorArray[ID] + 1 == LevelConfig.CubeGoal[ID])
        {
            _winOperatorArray[ID]++;
            _completedComboCount++;
        }
        else
        {
            return;
        }

        if (_completedComboCount == LevelConfig.CubeGoal.Length - 1)
        {
            OnGameWin?.Invoke();

            

            int tmp = PlayerPrefs.GetInt(TokenHelper.PassedLevelsKey);
            if (tmp <= 20 && tmp <= LevelConfig.LevelID)
            {
                tmp++;
                PlayerPrefs.SetInt(TokenHelper.PassedLevelsKey, tmp);
            }

            _startGetted = Mathf.Clamp(_startGetted, 0, 3);
            for (int i = 0; i < _startGetted; i++)
            {
                _stars[i].SetActive(true);
            }
        }

        UpdateCounterView();
    }

    public void UpdateCounterView()
    {
        for (int i = 1; i < _winOperatorArray.Length; i++)
        {
            int rewResult = (LevelConfig.CubeGoal[i] - _winOperatorArray[i]);

            _winReviewTextPanels[i].text = rewResult > 0 ? rewResult.ToString() : "+";
        }
    }


    public void GameLost()
    {
        if (!LevelConfig.IsInfinity)
        {
            OnGameLost?.Invoke();
        }
        else
        {
            OnGameWin.Invoke();
            _startGetted = 3;
        }
    }

    [ContextMenu("DeleteSave")]
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
    }

    #region Management
    private static bool _gameCanPullNewCubes = true;
    public static bool GameCanPullNewCubes => _gameCanPullNewCubes;

    public static void SetPullNewCubesAbilityState(bool State)
    {
        _gameCanPullNewCubes = State;
    }
    #endregion

    public void AddScore(int Value)
    {
        _score += Value;
        foreach (var item in _scoreRewTexts)
        {
            item.text = _score.ToString();
        }
    }
}
