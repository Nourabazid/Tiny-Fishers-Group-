using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level Page");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Back()
    {
        SceneManager.LoadScene("Start Page");
    }
}
