using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    public AudioSource ChangeAudio;
    public void Next_Level()
    {
        ChangeAudio.GetComponent<AudioSource>().Play();
        Invoke("Go_Next_Level", 0.3f);

    }


    public void Go_Next_Level()
    {
        Application.LoadLevel("Meau");
    }
   
}
