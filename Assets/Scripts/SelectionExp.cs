using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionExp : MonoBehaviour
{
    public void EnterStory(){
        SceneManager.LoadScene("");
    }
    
    public void EnterTraining(){
        SceneManager.LoadScene("");
    }

    public void Home(){
        SceneManager.LoadScene("selection_environment");
    }
}
