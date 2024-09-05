using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SwitchUI : MonoBehaviour
{
    [SerializeField] private Sprite _enabledSprite;
    [SerializeField] private Sprite _disabledSprite;

    private bool _state = true;
    [SerializeField, HideInInspector] private Image image;
    [SerializeField, HideInInspector] private Button button;

    private void OnValidate()
    {
        image ??= GetComponent<Image>();
        button ??= GetComponent<Button>();
    }

    private void Start()
    {
        button.onClick.AddListener(SwitchState);
    }

    public void SetSwitchVisualState(bool State)
    {
        _state = State;
        image.sprite = !_state ? _disabledSprite : _enabledSprite;
    }

    public void SwitchState()
    {
        _state = !_state;
        image.sprite = !_state ? _disabledSprite : _enabledSprite;
    }
}
