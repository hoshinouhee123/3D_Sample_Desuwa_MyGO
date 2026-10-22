using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public string gameScneneName = "SampleScene";
    

    public void StartGame()
    {
        SceneManager.LoadScene(gameScneneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
