using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private int _levelID;
    [SerializeField] private Sprite[] _stageSprites;
    [SerializeField] private Sprite[] _starsStageSprites;

    [SerializeField] private Text _levelNumberText;
    [SerializeField] private Image _starRef;
    [SerializeField, HideInInspector] private Image _image;
    [SerializeField] private Button _button;

    private bool _isLocked = false;

    private void OnValidate()
    {
        _levelNumberText.text = _levelID.ToString();
        _button ??= GetComponent<Button>();
        _image ??= GetComponent<Image>();
    }

    private void Start()
    {
       // _button.onClick.AddListener(PlayLevel);

        _isLocked = false;
        int psd = PlayerPrefs.GetInt(TokenHelper.PassedLevelsKey) + 1;

        if (_levelID < psd) _image.sprite = _stageSprites[0];
        else if (psd == _levelID) _image.sprite = _stageSprites[1];
        else
        {
            _image.sprite = _stageSprites[2];
            _levelNumberText.text = "";
            _isLocked = true;
        }

        _starRef.sprite = _starsStageSprites[PlayerPrefs.GetInt(TokenHelper.StartKeyPart + _levelID.ToString())];
    }

    public void PlayLevel()
    {
        Debug.Log("Play state " + _isLocked.ToString());
        if (_isLocked) return;
        GameManager.LevelConfig = LevelsContainer.instance.Levels[_levelID];
        SceneManager.LoadScene("GameplayScene");
    }
}
