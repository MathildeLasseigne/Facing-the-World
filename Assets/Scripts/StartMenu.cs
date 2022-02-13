using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Welcome"); //Enter the name of the next scene
    }

    public void QuitGame(){
        Application.Quit();
    }
}
