using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class grabClientID : MonoBehaviour
{
    public int playerID;
    public RealtimeView _realtime; 
    // Start is called before the first frame update
    void Start()
    {
        _realtime = GetComponent<RealtimeView>();
        playerID = _realtime.realtime.clientID;
        Debug.Log(playerID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
