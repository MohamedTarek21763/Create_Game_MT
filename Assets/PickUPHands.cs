using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PickUPHands : MonoBehaviour
{
    [SerializeField] float distToPickup = 0.3f;
    [SerializeField] LayerMask pickupLayer;
    bool handClosed = false;

    [SerializeField] SteamVR_Input_Sources handSource = SteamVR_Input_Sources.LeftHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
       // if(SteamVR_Actions.)
        
    }
}
