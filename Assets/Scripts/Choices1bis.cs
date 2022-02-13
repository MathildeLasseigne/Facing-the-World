using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices1bis : MonoBehaviour
{
    public void NextQuestion(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DayLight(){
        SingletonCalmEnv.Instance.light_type = "DAY_LIGHT";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void NightLight(){
        SingletonCalmEnv.Instance.light_type = "NIGHT_LIGHT";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
