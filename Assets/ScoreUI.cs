using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    static public ScoreUI instance;
    private void Awake()
    {
        instance = this;
    }
    public int score;
    public void AddScore(int addScore)
    {
        score += addScore;

        GetComponent<Text>().text = score.ToString();
    }
}
