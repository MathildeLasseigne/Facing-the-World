using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices2bis : MonoBehaviour
{
    public void NextQuestion(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Rain(){
        SingletonCalmEnv.Instance.sound_type = "RAIN";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SoothingMusic(){
        SingletonCalmEnv.Instance.sound_type = "MUSIC";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Fireplace(){
        SingletonCalmEnv.Instance.sound_type = "FIREPLACE";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Waves(){
        SingletonCalmEnv.Instance.sound_type = "WAVES";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Bird(){
        SingletonCalmEnv.Instance.sound_type = "BIRD";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Wind(){
        SingletonCalmEnv.Instance.sound_type = "WIND";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
