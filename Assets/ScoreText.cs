using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score;

    
    Text scoreText = null;
    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void AddScore(int addScore)
    {
        //score = score + addScore;
        score += addScore;
        scoreText.text = score.ToString();
    }
}
