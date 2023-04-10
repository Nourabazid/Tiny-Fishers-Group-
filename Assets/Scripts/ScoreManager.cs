using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    private Text scoreText;
    private int score=0;


    private void Start()
    {
        scoreText = FindObjectOfType<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        if(score<0)
        {
            score = 0;
        }
        scoreText.text = score.ToString();
    }

    public void AddScore(int PointstoAdd)
    {
       
            score += PointstoAdd;
    }

    public int GetScore()
    {
        return score;
    }
}
