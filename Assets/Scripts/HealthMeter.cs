using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthMeter : MonoBehaviour
{
   // public Text TimeandHealth;
    public float MaxHealth;
    public float health;
    private float hp;
    private GameObject player;
    public Image HPBar;

    private FinalScore final;

    private void Start()
    {
        final = FindObjectOfType<FinalScore>();
        player = GameObject.FindGameObjectWithTag("Player");
        health = MaxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        if(health>MaxHealth)
        {
            health = MaxHealth;
        }
        if(health<=0f)
        {
            final.Max_Score = 100;
            final.FinalText.text = "Final Score:" + final.Finalscore.ToString();
            SceneManager.LoadScene("Lose");
            final.Finalscore = 0;
        }

        BarFiller();
    }

    void BarFiller()
    {
        HPBar.fillAmount = health / MaxHealth;
    }

    public void Increase(float toAdd)
    {
        health += toAdd;
    }

    public void Decrease(float toMinus)
    {
        health -= toMinus;
    }
}
