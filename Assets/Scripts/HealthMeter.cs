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

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        health = MaxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        if(health<=0f)
        {
            SceneManager.LoadScene("Lose");
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
