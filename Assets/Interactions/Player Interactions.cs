using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{

    private PlayerControllers playerControllers;

    private void Awake() {
      playerControllers = new PlayerControllers();
    }

    private void OnEnable() {
      playerControllers.Enable();
    }

    private void OnDisable() {
      playerControllers.Disable();
    }

    void Start()
    {


    }

    private void Update (){
      playerControllers.WholeEnvironment.PlaySound.ReadValue<float>();
      if (playerControllers.WholeEnvironment.PlaySound.ReadValue<float>() == 1){
          Debug.Log("Sound");
      }

    }
}
