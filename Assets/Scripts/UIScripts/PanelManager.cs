using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public GameObject panelMode;

    public void showPanelMode()
    {
        panelMode.SetActive(true);
    }
    
    public void hidePanelMode()
    {
        panelMode.SetActive(false);
    }

    public void startGame(int count)
    {
        PlayerPrefs.SetInt(Const.MODE_COUNT,count);
        SceneManager.LoadSceneAsync(1);
    }
}