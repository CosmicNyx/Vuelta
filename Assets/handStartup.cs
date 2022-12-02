using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handStartup : MonoBehaviour
{

    public grabClientID clientID;

    // Start is called before the first frame update
    void Start()
    {

        //Transform leftHand = transform.Find("transfromAlignLeft");

        //-----------------------
        foreach (Transform child in transform)
        {
            if (clientID.playerID == 0 && child.gameObject.name == "player1")
            {
                child.gameObject.SetActive(true);
                //leftHand.gameObject.SetActive(false);
            }
            else if (clientID.playerID == 1 && child.gameObject.name == "player2")
            {
                child.gameObject.SetActive(true);
            }
            else if (clientID.playerID == 2 && child.gameObject.name == "player3")
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
