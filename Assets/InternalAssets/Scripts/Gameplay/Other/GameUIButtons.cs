using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameUIButtons : MonoBehaviour
{
    public static int _loadParametre = 0;

    [SerializeField] private LevelConfig _endlessLevel;

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("EnterScreen");
    }

    public void GotoHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void LoadEndlessLevel()
    {
        GameManager.LevelConfig = _endlessLevel;    
        SceneManager.LoadScene("GameplayScene");
    }

    public void RunNextLevel()
    {
        GameManager.LevelConfig = LevelsContainer.instance.Levels[PlayerPrefs.GetInt(TokenHelper.PassedLevelsKey) + 1];
        SceneManager.LoadScene("GameplayScene");
    }

    public void setLoadParam(int param)
    {
        _loadParametre = param;
    }
}
