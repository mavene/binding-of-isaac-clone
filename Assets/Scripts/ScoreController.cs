using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI inGameScoreText;
    public TextMeshProUGUI gameOverScoreText;

    [System.NonSerialized]
    public int score = 0; // Hide from inspector

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void UpdateScore(int value)
    {
        score += value;
        inGameScoreText.text = "Score: " + score.ToString();
        //gameOverScoreText.text = inGameScoreText.text;
    }
    public void UpdateScore5()
    {
        score += 3;
        inGameScoreText.text = "Score: " + score.ToString();
        //gameOverScoreText.text = inGameScoreText.text;
    }

    public void FinaliseScore()
    {
        gameOverScoreText.text = inGameScoreText.text;
    }

    public void ResetScore()
    {
        score = 0;
        inGameScoreText.text = "Score: 0";
    }
}
