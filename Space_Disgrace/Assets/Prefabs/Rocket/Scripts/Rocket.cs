using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.E))
        {
            rigidBody.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.W))
        {
            print("Left");
        }
        else if (Input.GetKey(KeyCode.R))
        {
            print("Right");
        }
    }
}
