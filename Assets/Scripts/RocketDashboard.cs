using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class RocketDashboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;
    private float score;

    private void Update()
    {
        CurrentScore();
        HighScore();
    }

    private void CurrentScore()
    {
        score = this.transform.position.y - 0.4f;
        ShowCurrentScore();
    }

    private void ShowCurrentScore()
    {
        string showScore = score.ToString("N2");
        currentScoreTxt.text = $"{showScore} M";
    }

    private void HighScore()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            float highscore = PlayerPrefs.GetFloat("highScore");

            if (highscore < score)
            {
                PlayerPrefs.SetFloat("highScore", score);
                HighScoreTxt.text = score.ToString("N2") + "M";
            }
            else
            {
                HighScoreTxt.text = highscore.ToString("N2") + "M";
            }
        }
        else
        {
            PlayerPrefs.SetFloat("highScore", score);
            HighScoreTxt.text = score.ToString("N2") + "M";
        }
    }
}
