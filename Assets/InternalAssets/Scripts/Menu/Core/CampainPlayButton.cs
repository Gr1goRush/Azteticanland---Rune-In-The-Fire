using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampainPlayButton : MonoBehaviour
{
    [SerializeField] private int _DebugSaved;

    public void ContinuePlay()
    {
        GameManager.LevelConfig = LevelsContainer.instance.Levels[PlayerPrefs.GetInt(TokenHelper.PassedLevelsKey) + 1];
        SceneManager.LoadScene("GameplayScene");        
    }


    [ContextMenu("DebugSetLevel")]
    public void DebugSetLevel()
    {
        PlayerPrefs.SetInt(TokenHelper.PassedLevelsKey, _DebugSaved);
    }
    [ContextMenu("DebugClearAll")]
    public void DebugClearAll()
    {
        PlayerPrefs.DeleteAll();
    }
}

public class TokenHelper
{
    public const string PassedLevelsKey = "PsdLV";
    public const string StartKeyPart = "StrKP";
}
