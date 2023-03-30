using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text TimeandHealth;
    public float MaxHealth;
    private float health;
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
        if(health==0f)
        {
            SceneManager.LoadScene("Lose");
        }

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            hp += Time.deltaTime * 1;
            health =MaxHealth- hp;
            TimeandHealth.text = "Health:" + ((int)health).ToString();
        }

        BarFiller();
    }

    void BarFiller()
    {
        HPBar.fillAmount = health / MaxHealth;
    }
}
