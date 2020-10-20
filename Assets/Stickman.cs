using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman : MonoBehaviour
{
    public Camera mainCamera;
    Rigidbody2D rigidBody;

    public float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, rigidBody.velocity.y + jumpForce);
        }

        mainCamera.transform.position = new Vector3(transform.position.x + 5, transform.position.y + 1, mainCamera.transform.position.z);
    }


    private void FixedUpdate()
    {

        


    }
}
