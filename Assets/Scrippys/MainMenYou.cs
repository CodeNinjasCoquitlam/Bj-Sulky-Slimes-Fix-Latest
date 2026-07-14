using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenYou : MonoBehaviour
{
    public GameObject ControlScreen;
    public GameObject AboutScreen;

    public void OpenControl()
    {
        ControlScreen.SetActive(true);
    }
    public void CloseControl()
    {
        ControlScreen.SetActive(false);
    }
    public void OpenAbout()
    {
        AboutScreen.SetActive(true);
    }
    public void CloseAbout()
    {
        AboutScreen.SetActive(false);
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevelSelect()
    {
        SceneManager.LoadScene(1);
    }
}
