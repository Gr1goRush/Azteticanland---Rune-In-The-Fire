using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOperator : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent OnGameEndedAndMidBlank;
    public static event System.Action<Vector2, Vector2, Vector2> OnCubeDestroyed;
    public static event System.Action<Vector2, Vector2, Vector2> OnThreeFinded;
    public static event System.Action<int> OnThreeColected;

    [Header("Effects")]
    [SerializeField] private VFXPlayer _vFXPlayer;
    [SerializeField] VFXPlayer _axevFXPlayer;

    [Space(30f)]
    [SerializeField] private CubeGridField _cubeGridField;

    [Header("Audio")]
    [SerializeField] private AudioClip _hitThreeAudio;

    private GridArray _gridArray => _cubeGridField.GridField;
    private int[,] GridField => _gridArray.Fields;
    private void OnValidate()
    {
        _cubeGridField ??= FindObjectOfType<CubeGridField>();
    }

    private void OnEnable()
    {
        Cube.OnCubePlaced += RecalculateArray;
        Cube.OnTouchAxe += SummonAxeVFX;
    }

    private void OnDisable()
    {
        Cube.OnCubePlaced -= RecalculateArray;
        Cube.OnTouchAxe -= SummonAxeVFX;
    }

    public void RecalculateArray()
    {
        int rows = GridField.GetLength(0);
        int columns = GridField.GetLength(1);

        // Проверка по горизонталиs
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns - 2; col++)
            {
                int current = GridField[row, col];
                if (current != 0 && GridField[row, col + 1] == current && GridField[row, col + 2] == current)
                {
                    OnThreeColected?.Invoke(GridField[row, col]);
                    StartCoroutine(DestroyThreeRoutine(row, col, false));
                }
            }
        }

        // Проверка по вертикали
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows - 2; row++)
            {
                int current = GridField[row, col];
                if (current != 0 && GridField[row + 1, col] == current && GridField[row + 2, col] == current)
                {
                    OnThreeColected.Invoke(GridField[row, col]);
                    StartCoroutine(DestroyThreeRoutine(row, col, true));
                    
                }
            }
        }
    }

    private IEnumerator DestroyThreeRoutine(int row, int col, bool Vertical)
    {
        while (Settings.GameIsPaused)
        {
            yield return new WaitForEndOfFrame();
        }

        if (Vertical)
        {
            GameManager.SetPullNewCubesAbilityState(false);
            Vector3 spawnPos = _gridArray.ConvertGridPointToWorldPoint(row + 1, col);

            Instantiate(_vFXPlayer, spawnPos, Quaternion.identity);
            OnThreeFinded?.Invoke(_gridArray.ConvertGridPointToWorldPoint(row, col), _gridArray.ConvertGridPointToWorldPoint(row + 1, col), _gridArray.ConvertGridPointToWorldPoint(row + 2, col));
            yield return new WaitForSeconds(200 * Time.deltaTime);
            //GridField[row, col] = GridField[row + 1, col] = GridField[row + 2, col] = 0;

            DeviceHelper.PlayVibration();
            GameManager.SetPullNewCubesAbilityState(true);
            AudioManager.instance.PlayClip(_hitThreeAudio);

            while (Settings.GameIsPaused)
            {
                yield return new WaitForEndOfFrame();
            }

            GameManager.instance.AddScore(250);
            //OnCubeDestroyed?.Invoke(_gridArray.ConvertGridPointToWorldPoint(row, col), _gridArray.ConvertGridPointToWorldPoint(row + 1, col), _gridArray.ConvertGridPointToWorldPoint(row + 2, col));
        }
        else
        {
            GameManager.SetPullNewCubesAbilityState(false);
            Vector3 spawnPos = _gridArray.ConvertGridPointToWorldPoint(row, col + 1);

            Instantiate(_vFXPlayer, spawnPos, Quaternion.Euler(0, 0, 90));
            OnThreeFinded?.Invoke(_gridArray.ConvertGridPointToWorldPoint(row, col), _gridArray.ConvertGridPointToWorldPoint(row, col + 1), _gridArray.ConvertGridPointToWorldPoint(row, col + 2));
            yield return new WaitForSeconds(200 * Time.deltaTime);
            //GridField[row, col] = GridField[row, col + 1] = GridField[row, col + 2] = 0;

            AudioManager.instance.PlayClip(_hitThreeAudio);
            DeviceHelper.PlayVibration();
            GameManager.SetPullNewCubesAbilityState(true);

            while (Settings.GameIsPaused)
            {
                yield return new WaitForEndOfFrame();
            }

            GameManager.instance.AddScore(250);
            //OnCubeDestroyed?.Invoke(_gridArray.ConvertGridPointToWorldPoint(row, col), _gridArray.ConvertGridPointToWorldPoint(row, col + 1), _gridArray.ConvertGridPointToWorldPoint(row, col + 2));
        }
    }

    public void CheckForGiveStar()
    {
        for (int i = 0; i < GridField.GetLength(0); i++)
        {
            if (GridField[i, 4] != 0) return;
        }

        OnGameEndedAndMidBlank?.Invoke();
    }

    public void SummonAxeVFX(int YID)
    {
        GameManager.instance.AddScore(750);
        Vector3 spawnPos = _gridArray.ConvertGridPointToWorldPoint(2, YID);
        Instantiate(_axevFXPlayer, spawnPos, Quaternion.identity);
    }
}
