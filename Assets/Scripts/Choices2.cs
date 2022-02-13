using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choices2 : MonoBehaviour
{
    public void isSound(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void isNotSound(){
        SingletonCalmEnv.Instance.sound_type = "NONE";
        SceneManager.LoadScene("Questionnaire_3");
    }
}
