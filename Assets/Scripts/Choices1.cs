using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Choices1 : MonoBehaviour
{
    Text result;

    public void Start(){

    }

    public void NextQuestion(GameObject currentButton){
        result =  currentButton.GetComponentInChildren<Text>(true);
        SingletonCalmEnv.Instance.background = result.text;
        //Debug.Log(SingletonCalmEnv.Instance.background);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Forest(){
        SingletonCalmEnv.Instance.background = "FOREST";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Mountain(){
        SingletonCalmEnv.Instance.background = "MOUNTAIN";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Beach(){
        SingletonCalmEnv.Instance.background = "BEACH";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Sky(){
        SingletonCalmEnv.Instance.background = "SKY";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Fire(){
        SingletonCalmEnv.Instance.background = "FIRE";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Cityscape(){
        SingletonCalmEnv.Instance.background = "CITYSCAPE";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
