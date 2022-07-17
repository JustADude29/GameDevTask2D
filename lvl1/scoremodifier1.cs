using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoremodifier1 : MonoBehaviour
{
    public static scoremodifier1 instance;

    public static int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private void awake(){
        instance = this;
    }

    private void start(){
        score=0;
        
    }

    public void AddPoint(){
        score ++;
    }

    private void Update()
    {
        scoreText.SetText(score.ToString());
        highScoreText.SetText("HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString());
        
    }
}
