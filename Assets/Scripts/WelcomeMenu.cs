using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeMenu : MonoBehaviour
{
    public void StartQuestionnaire(){
        SceneManager.LoadScene("QUestionnaire_1");
    }
}
