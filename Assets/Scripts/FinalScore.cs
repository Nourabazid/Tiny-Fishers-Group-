using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    public int Finalscore;
    public Text FinalText;
    private ScoreManager thescoremanager;
    public int Max_Score;
    // Start is called before the first frame update
    void Start()
    {
        thescoremanager = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        Finalscore = thescoremanager.GetScore();

        if (Finalscore>= Max_Score)
        {
            Max_Score = 100;
            FinalText.text = "Final Score:" + Finalscore.ToString();
            SceneManager.LoadScene("Win");
            Finalscore = 0;
        }
    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }
}
