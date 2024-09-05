using UnityEngine;

public class CubeGridField : MonoBehaviour
{
    [SerializeField] private float _gizmosGridDrawSize = 0.5f;

    [Space(30f)]
    [SerializeField] private float XGap;
    [SerializeField] private float YGap;

    [SerializeField] private int _gridWidth = 5;
    [SerializeField] private int _gridHeight = 11;

    [SerializeField] private GridArray _gridField;
    public GridArray GridField => _gridField;

    private void OnValidate()
    {
        _gridField = new GridArray(_gridWidth, _gridHeight, XGap, YGap, transform);
    }

    private void Start()
    {
        _gridField = new GridArray(_gridWidth, _gridHeight, XGap, YGap, transform);
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        //Gizmos.DrawGUITexture(new Rect(transform.position.x, transform.position.y, 200, 100), Resources.Load<Texture2D>("GUITexture"));

        for (int x = 0; x < _gridField.Fields.GetLength(0); x++)
        {
            for (int y = 0; y < _gridField.Fields.GetLength(1); y++)
            {
                Gizmos.color = _gridField.Fields[x, y] == 0 ? Color.green : Color.red;
                Vector2 GizmosPosition = _gridField.ConvertGridPointToWorldPoint(x, y);
                Gizmos.DrawWireCube(GizmosPosition, Vector2.one * _gizmosGridDrawSize);
                UnityEditor.Handles.Label(GizmosPosition, _gridField.Fields[x,y].ToString());
            }
        }
    }

#endif
    public void ShiftValuesUpAndFillBottom(int MaxRandomID)
    {
        _gridField.ShiftValuesUp();
        _gridField.FillBottomRandom(MaxRandomID);

        
    }
}
