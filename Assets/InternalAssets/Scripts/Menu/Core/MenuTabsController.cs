using UnityEngine;

public class MenuTabsController : MonoBehaviour
{
    [SerializeField] private GameObject[] _tabs;

    private void Start()
    {
        if (GameUIButtons._loadParametre != 0)
        {
            OpenTab(GameUIButtons._loadParametre);
            GameUIButtons._loadParametre = 0;
        }
    }
    public void OpenTab(int TabID)
    {
        foreach (var item in _tabs)
        {
            item.SetActive(false);
        }
        _tabs[TabID].SetActive(true);
    }
}
