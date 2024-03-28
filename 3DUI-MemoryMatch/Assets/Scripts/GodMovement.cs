using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GodMovement : MonoBehaviour
{
    public GameObject rightHand, leftHand;
    public InputActionReference rightHandGrab, leftHandGrab;
    GameObject parentEnviroment;
    bool rightHandClosed, leftHandClosed = false;

    // Start is called before the first frame update
    void Start()
    {
        parentEnviroment = GameObject.Find("TestEnviroment");
    }

    // Update is called once per frame
    void Update()
    {
        if (rightHandGrab.action.ReadValue<float>() > .5f) {
            rightHandClosed = true;
        } else {
            rightHandClosed = false;
        }
        if (rightHandGrab.action.ReadValue<float>() > .5f) {
            rightHandClosed = true;
        } else {
            rightHandClosed = false;
        }
    }
}
