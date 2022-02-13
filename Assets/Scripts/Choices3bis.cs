using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices3bis : MonoBehaviour
{
    public void Woman(){
        SingletonCalmEnv.Instance.voice_type = "WOMAN";
        SceneManager.LoadScene("selection_environment");
    }
    public void Man(){
        SingletonCalmEnv.Instance.voice_type = "MAN";
        SceneManager.LoadScene("selection_environment");
    }
}
