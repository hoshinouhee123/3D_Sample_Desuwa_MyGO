using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gmaeOverPanel;
    public string titleSceneName = "Title";

    public GameObject clearPanel;

    void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gmaeOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Retry()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }
    

    public void GoTitle()
    {
        SceneManager.LoadScene(titleSceneName);
    }


    public void GameClear()
    {
        clearPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
