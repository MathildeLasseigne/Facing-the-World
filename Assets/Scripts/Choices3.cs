using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices3 : MonoBehaviour
{
    public void NextQuestion(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Text(){
        SingletonCalmEnv.Instance.communication = "TEXT";
        SceneManager.LoadScene("selection_environment");
    }

    public void Voice(){
        SingletonCalmEnv.Instance.communication = "VOICE";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Both(){
        SingletonCalmEnv.Instance.communication = "BOTH";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
