using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public AudioSource[] soundFX;

    //SOUND 1
    public void sound1()
    {
        soundFX[0].Play();
        Debug.Log("Rprime - A");
    }

    //SOUND 2
    public void sound2()
    {
        Debug.Log("Rsecond - S");
    }

    //SOUND 3
    public void sound3()
    {
        Debug.Log("Lprime - D");
    }

    //SOUND 4
    public void sound4()
    {
        Debug.Log("Lsecond - F");
    }

}
