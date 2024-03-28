using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMovement : MonoBehaviour
{
    public GameObject rightHand, leftHand;
    GameObject parentEnviroment;
    bool rightHandClosed, leftHandClosed;

    // Start is called before the first frame update
    void Start()
    {
        parentEnviroment = GameObject.Find("TestEnviroment");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
