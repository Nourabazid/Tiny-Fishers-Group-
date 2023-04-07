using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    private int Finalscore;
    public Text FinalText;
    private ScoreManager thescoremanager;
    // Start is called before the first frame update
    void Start()
    {
        thescoremanager = FindObjectOfType<ScoreManager>();
        Finalscore = thescoremanager.GetScore();
        FinalText.text = Finalscore.ToString();
    }
    
}
