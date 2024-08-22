using UnityEngine;
using UnityEngine.UI;

public class ForYourScore : MonoBehaviour
{
    public int score, BetterScore;
    public Text scoreText, BetterScoreText;
    
    private void Start()
    {
        score = PlayerPrefs.GetInt("Your score:", score);
        scoreText.text = score.ToString();

        BetterScore = PlayerPrefs.GetInt("SaveScore", BetterScore);
        BetterScoreText.text = BetterScore.ToString();

    }
}
