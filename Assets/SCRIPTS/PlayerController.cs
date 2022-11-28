using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerController : MonoBehaviour
{

    private PlayerControls playerControls;




    private void Awake()
    {
        playerControls = new PlayerControls();
    }


    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisabled()
    {
        playerControls.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void play()
    {
        Debug.Log("die");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
