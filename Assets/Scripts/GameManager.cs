using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasGameEnded = false;
    float endGameDelay = 2f;
    public void EndGame()
    {
        if (hasGameEnded == false)
        {
            Debug.Log("Game Has Ended");
            hasGameEnded = true;
            FindObjectOfType<Score>().StopScore();
            Invoke("Restart", endGameDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
