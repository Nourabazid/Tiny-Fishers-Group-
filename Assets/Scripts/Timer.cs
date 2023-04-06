using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   // public Text TimeandHealth;
    public float MaxTime;
    public float Timeleft;
    private float TimetoDecrease;
    private GameObject player;
    public Image TimeIcon;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Timeleft = MaxTime;
    }
    // Update is called once per frame
    void Update()
    {
        if(Timeleft>MaxTime)
        {
            Timeleft = MaxTime;
        }
        if(Timeleft<=0f)
        {
            SceneManager.LoadScene("Lose");
        }

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            TimetoDecrease += Time.deltaTime * 1;
            Timeleft =MaxTime- TimetoDecrease;
           // TimeandHealth.text = "Health:" + ((int)health).ToString();
        }

        BarFiller();
    }

    void BarFiller()
    {
        TimeIcon.fillAmount = Timeleft/ MaxTime;
    }

    public void Increase(float toAdd)
    {
        TimetoDecrease-= toAdd;
    }

    public void Decrease(float toMinus)
    {
        TimetoDecrease+= toMinus;
    }
}
