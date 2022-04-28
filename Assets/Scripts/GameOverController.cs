using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverUI;
    public TMP_Text scoreTxt, rodsTxt, minDelayTxt, maxDelayTxt;
    public void GameOver(int score)
    {
        gameOverUI.SetActive(true);
        scoreTxt.text = "Score: " + PlayerPrefs.GetInt("Score", 0).ToString();
        rodsTxt.text = "Rods start speed: " + PlayerPrefs.GetFloat("RodsStartSpeed", 0f).ToString();
        minDelayTxt.text = "Minimum start delay: " + PlayerPrefs.GetFloat("MinimumStartDelay", 0f).ToString();
        maxDelayTxt.text = "Maximum start delay: " + PlayerPrefs.GetFloat("MaximumStartDelay", 0f).ToString();
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
