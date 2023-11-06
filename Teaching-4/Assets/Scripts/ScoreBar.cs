using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour
{
    public Text ShowScore;
    public static int Score;
    public int Highest_Score;
    public Text Score_End;
    public Text High_Score_End;

    private void Start()
    {
        Highest_Score = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Update()
    {
        ShowScore.text = Score.ToString();
        High_Score_End.text = Highest_Score.ToString();
        Score_End.text = Score.ToString();
        if (Score > Highest_Score)
        {
            Highest_Score = Score;
            PlayerPrefs.SetInt("HighScore", Highest_Score);
            PlayerPrefs.Save();
        }
    }
}