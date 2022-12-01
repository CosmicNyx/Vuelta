using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public AudioSource[] soundFX;
    //int id = 1;
    public grabClientID clientID;

    //SOUND 1
    public void sound1()
    {
        if (clientID.playerID == 0)
        {
            soundFX[0].Play();
            //Debug.Log("Rprime - A");
        }
        else if (clientID.playerID == 1)
        {
            soundFX[4].Play();
        }
        else if (clientID.playerID == 2)
        {
            soundFX[8].Play();
        }
    }

    //SOUND 2
    public void sound2()
    {
        if (clientID.playerID == 0)
        {
            soundFX[1].Play();
            //Debug.Log("Rsecond - S");
        }
        else if (clientID.playerID == 1)
        {
            soundFX[5].Play();
        }
        else if (clientID.playerID == 2)
        {
            soundFX[9].Play();
        }

    }

    //SOUND 3
    public void sound3()
    {
        if (clientID.playerID == 0)
        {
            soundFX[2].Play();
            //Debug.Log("Lprime - D");
        }
        else if (clientID.playerID == 1)
        {
            soundFX[6].Play();
        }
        else if (clientID.playerID == 2)
        {
            soundFX[10].Play();
        }

    }

    //SOUND 4
    public void sound4()
    {
        if (clientID.playerID == 0)
        {
            soundFX[3].Play();
            //Debug.Log("Lsecond - F");
        }
        else if (clientID.playerID == 1)
        {
            soundFX[7].Play();
        }
        else if (clientID.playerID == 2)
        {
            soundFX[11].Play();
        }

    }

}
