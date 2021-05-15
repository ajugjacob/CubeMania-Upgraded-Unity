using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text score;
    private float Offset;
    private float UpdatedScore;
    private bool hasGameEnded = false;


    private void Start()
    {
        Offset = Player.position.z;
    }

    void Update()
    {   
        if(hasGameEnded == false)
        {
            UpdatedScore = (Player.position.z - Offset) / 5;
            score.text = UpdatedScore.ToString("0");
        }
    }

    public void StopScore()
    {
        hasGameEnded = true;
    }
}
