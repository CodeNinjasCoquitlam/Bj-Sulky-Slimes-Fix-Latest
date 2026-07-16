using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerManagerManager : MonoBehaviour
{
    public GameObject[] FakeButtons;
    public GameObject[] RealButtons;

    public int unlockedLevelsIndex;

    void Start()
    {
        unlockedLevelsIndex = PlayerPrefs.GetInt("LevelIndex", 0);
        unlockedLevelsIndex += 1;
        for (int i = 1; i < unlockedLevelsIndex; i++)
        {
            FakeButtons[i].SetActive(false);
            RealButtons[i].SetActive(true);

            Debug.Log(unlockedLevelsIndex);
        }
    }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level += 1);
    }

    public void UnlockAllLevels()
    {
        for (int i = 0; i < 7; i++)
        {
            FakeButtons[i].SetActive(false);
            RealButtons[i].SetActive(true);

            Debug.Log(unlockedLevelsIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerPrefs.SetInt("LevelIndex", 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            UnlockAllLevels();
        }
    }
}
