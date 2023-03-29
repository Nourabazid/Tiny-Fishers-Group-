using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtoncontrollerStart : MonoBehaviour
{
    [SerializeField] private string StartGame = "Level Page";

    public void NewGameButton()
    {
        SceneManager.LoadScene(StartGame);
    }
}
