using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonlevel1 : MonoBehaviour
{
    [SerializeField] private string newGamelevel1 = "Game";
    
    public void Level1Button()
    {
        SceneManager.LoadScene(newGamelevel1);

    }
}

