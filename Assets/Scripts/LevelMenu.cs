using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    public void Level1()
    {
        SceneManager.LoadScene("Game");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Game 1");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Game 2");
    }
    public void Back()
    {
        SceneManager.LoadScene("Start Page");
    }
}
