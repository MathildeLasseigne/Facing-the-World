using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionEnv : MonoBehaviour
{
    public void PlayExperience(){
        SceneManager.LoadScene("selection_experience");
    }

    public void PlayCalm(){
        if(SingletonCalmEnv.Instance.background == "FOREST"){
            if(SingletonCalmEnv.Instance.light_type == "DAY_LIGHT"){
                SceneManager.LoadScene("Forest_Sunset");
            }else{
                SceneManager.LoadScene("Forest_Dusk");
            }
        }else{
        SceneManager.LoadScene("");
        }
    }


    public void Home(){
        SceneManager.LoadScene("Start_Menu");
    }
}
