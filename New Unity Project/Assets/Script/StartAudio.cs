using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{
    public AudioSource BingeAudio;
   

    // Update is called once per frame
    void Start()
    {
        BingeAudio.Play();
    }
}
