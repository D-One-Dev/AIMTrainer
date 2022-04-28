using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene("Gameplay");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
