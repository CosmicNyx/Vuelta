using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{


    private PlayerInput playerInput;
    private InputAction pressAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        pressAction = playerInput.actions["press"];
        pressAction.ReadValue<float>();
    }


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

    public void play()
    {
        Debug.Log("die");
    }

}
