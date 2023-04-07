using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    private Text scoreText;
    public int Max_Score;
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

        if(score>=Max_Score)
        {
            SceneManager.LoadScene("Level Page");
            score = 0;
        }
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
