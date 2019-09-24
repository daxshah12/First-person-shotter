using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 10.0f;
	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

        float moveZ = Input.GetAxis("Vertical") * speed;
        float moveX = Input.GetAxis("Horizontal") * speed;
        moveZ *= Time.deltaTime;
        moveX *= Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);

        if(Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
	}

    internal void Move(Vector3 movement)
    {
        throw new NotImplementedException();
    }
}
