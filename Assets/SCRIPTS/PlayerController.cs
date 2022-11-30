using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{


    //private PlayerInput playerInput;
    //private InputAction pressAction;

    //private void Awake()
    //{
    //    playerInput = GetComponent<PlayerInput>();
    //    pressAction = playerInput.actions["press"];
    //    pressAction.ReadValue<float>();
    //}


    //private PlayerControls playerControls;

    //private void Awake()
    //{
    //    playerControls = new PlayerControls();
    //}

    //private void OnEnable()
    //{
    //    playerControls.Enable();
    //}

    //private void OnDisabled()
    //{
    //    playerControls.Disable();
    //}

    //FindObjectOfType<AudioManager>().Play("Player1");


    public AudioSource[] soundFX;


    public void press()
    {
        soundFX[0].Play();

        Debug.Log("die");
    }

}
