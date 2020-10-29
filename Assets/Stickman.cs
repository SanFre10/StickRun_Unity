using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman : MonoBehaviour
{
    public Camera mainCamera;
    Rigidbody2D rigidBody;
    Animator animator;
    public Transform groundCheck;
    public LayerMask groundMask;

    bool isGrounded = false;
    public float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Saltar (solo si estoy tocando el suelo)
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }

        mainCamera.transform.position = new Vector3(transform.position.x + 5, transform.position.y + 1, mainCamera.transform.position.z);

        //Control de las animaciones
        animator.SetBool("IsRunning", isGrounded);

        //Evita la rotacion por el collider tipo capsula
        if(transform.rotation.z != 0)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 0,0);
        }
    }


    private void FixedUpdate()
    {
        //Chequeo del piso
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.02f, groundMask);
    }
}
