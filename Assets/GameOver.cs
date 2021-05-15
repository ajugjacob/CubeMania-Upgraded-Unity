using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text CurrentScore;
    public Text HighScore;

    public void Start()
    {
        HighScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
        CurrentScore.text = PlayerPrefs.GetFloat("CurrentScore").ToString("0");
    }

    public void Restart ()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
