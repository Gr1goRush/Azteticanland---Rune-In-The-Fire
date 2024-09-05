using UnityEngine;
public class GridArray
{
    public static event System.Action OnCubeOutOfRange;
    private int width;
    private int height;
    private int[,] _fields;

    private float XGap;
    private float YGap;

    private Transform _rootTransform;
    private Vector2 _rootPosition => _rootTransform.position;

    public int[,] Fields => _fields;
    private bool _canSpawnAxe = true;
    public GridArray(int width, int height, float XGap, float YGap, Transform Root)
    {
        this.width = width;
        this.height = height;

        this.XGap = XGap;
        this.YGap = YGap;

        _rootTransform = Root;

        _fields = new int[this.width, this.height];
    }

    public Vector2 ConvertGridPointToWorldPoint(int x, int y)
    {
        return (_rootPosition + new Vector2(x * XGap, y * YGap));
    }

    public void SetIDtoGridPoint(int CubeID, int x, int y)
    {
        _fields[x, y] = CubeID;
    }

    public bool PointContainsID(int x, int y)
    {
        return _fields[x, y] != 0;
    }

    public void ShiftValuesUp()
    {
        int rowCount = _fields.GetLength(0);
        int columnCount = _fields.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            int previousValue = _fields[i, columnCount - 1];

            for (int j = columnCount - 2; j >= 0; j--)
            {
                int currentValue = _fields[i, j];
                _fields[i, j] = previousValue;

                previousValue = currentValue;

                if (j == 0 && previousValue != 0)
                {
                    OnCubeOutOfRange?.Invoke();
                }
            }

            _fields[i, columnCount - 1] = previousValue;
        }
    }

    public void FillBottomRandom(int MaxID)
    {
        int j = _fields.GetLength(1) - 1;
        for (int i = 0; i < _fields.GetLength(0); i ++)
        {
            int random = UnityEngine.Random.Range(1, MaxID);
            if (_canSpawnAxe && UnityEngine.Random.Range(0, 100) > 70)
            {
                random = 999;
                _canSpawnAxe = false;
            }
            _fields[i, j] = random;
        }
    }
}
