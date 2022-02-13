using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonCalmEnv : MonoBehaviour
{
    public static SingletonCalmEnv Instance { get; private set; }

    public string background;
    public string light_type;
    public string sound_type;
    public string communication;
    public string voice_type;


     private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
     }
}
