using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Prototype_1");
    }

    public void Quit(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

