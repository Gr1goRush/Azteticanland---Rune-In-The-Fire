using System;
using System.Collections;
using UnityEngine;
public class CubeDropperMovementSystem : MonoBehaviour
{
    public static Action<int> OnNewDotSelected;
    [Header("Debug")]
    [Tooltip("The size of the control point renderer sphere")]
    [SerializeField] private float _gizmosControldotSphereRadius = 0.2f;

    [Tooltip("The color of the control point renderer sphere")]
    [SerializeField] private Color _gizmosControldotSphereColor = Color.cyan;
    private Vector3 _dotsAutoCorrectValue => Vector3.right * 3;


    [Tooltip("Checkpoints are places where the player can bring the CubeDropper")]
    [SerializeField] private Vector3[] _controlDots;

    private bool _isEnabled;
    //private bool _alreadyInMove;

    public static int _currentDotSelected = 0;

    [Header("Animations")]
    [SerializeField] private Animator _animator;


    #region AuxiliaryProperties
    private Vector3 _ownPosition => transform.position;
    #endregion

    #region Gizmos
    private void OnDrawGizmos()
    {
        if (_controlDots == null || _controlDots.Length < 2) return;

        for (int i = 0; i < _controlDots.Length; i++)
        {
            Gizmos.color = _gizmosControldotSphereColor;
            Gizmos.DrawWireSphere(_controlDots[i], _gizmosControldotSphereRadius);
        }
    }

    #endregion

    private void OnValidate()
    {
        if (_controlDots == null || _controlDots.Length < 2)
        {
            Debug.LogError("ERROR - The number of control points cannot be less than two, auto-correction is applied");

            
            _controlDots = new Vector3[2];
            _controlDots[0] = _ownPosition + _dotsAutoCorrectValue;
            _controlDots[1] = _ownPosition - _dotsAutoCorrectValue;
        }

    }

    
    private void Start()
    {
        transform.position = _controlDots[_currentDotSelected];
        _isEnabled = true;
    }

    
    private void Update()
    {
        if (!_isEnabled) return;
        if (Settings.GameIsPaused) return;

        if (Input.GetMouseButtonDown(0))
        {
            StopAllCoroutines();
            StartCoroutine(SmoothMoveTo(CalculateSelectedDot(Camera.main.ScreenToWorldPoint(Input.mousePosition))));
            
        }
    }

    public IEnumerator SmoothMoveTo(Vector3 Position)
    {
        Position += Vector3.right / 2;

        float distance = Vector3.Distance(transform.position, Position);
        float speed = 6f; // увеличили скорость до 6f

        while (distance > 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, Position, speed * Time.deltaTime);
            distance = Vector3.Distance(transform.position, Position);
            yield return new WaitForEndOfFrame();
        }

        if (!Settings.GameIsPaused)
        {
            _animator.Play("shoot");
        }
    }

    private Vector3 CalculateSelectedDot(Vector3 TouchPosition)
    {
        float MinDistanceBetweenTouchAndControlDot = Vector3.Distance(TouchPosition, _controlDots[0]);
        int ResultControlDot = 0;

        for (int i = 1; i < _controlDots.Length; i++)
        {
            float CurrentCycleMinDist = Vector3.Distance(TouchPosition, _controlDots[i]);

            if (CurrentCycleMinDist < MinDistanceBetweenTouchAndControlDot)
            {
                ResultControlDot = i;
                MinDistanceBetweenTouchAndControlDot = CurrentCycleMinDist;
            }
        }

        _currentDotSelected = ResultControlDot;
        return _controlDots[ResultControlDot];
    }

    public void SetActivity(bool State)
    {
        _isEnabled = State;
    }

    [ContextMenu("Debug_FixYPos")]
    public void AutoCorrectDotsYPosition()
    {
        for (int i = 0; i < _controlDots.Length; i++)
        {
            Vector3 FixedPosition = _controlDots[i];
            FixedPosition.y = _ownPosition.y;
            _controlDots[i] = FixedPosition;
        }
    }

    public void SummonANewCube()
    {
        Debug.Log($"Try to invoke with {_currentDotSelected}");
        OnNewDotSelected?.Invoke(_currentDotSelected);
    }
}
