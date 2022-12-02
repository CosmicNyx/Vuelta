using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormcoreSwapHead : MonoBehaviour
{
    public string objectName;

    public grabClientID clientID;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if (clientID.playerID == 0 && child.gameObject.name == "head4")
            {
                child.gameObject.SetActive(true);
                //leftHand.gameObject.SetActive(false);
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
