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
    bool isSliding = false;
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
        isSliding = false;
        // Saltar (solo si estoy tocando el suelo)
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded)
        {
            rigidBody.velocity = new Vector2(0, jumpForce);
        }
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && isGrounded)
        {
            isSliding = true;
        }

        mainCamera.transform.position = new Vector3(transform.position.x + 5, mainCamera.transform.position.y, mainCamera.transform.position.z);

        //Control de las animaciones
        animator.SetBool("IsJumping", rigidBody.velocity.y > 0.1);
        animator.SetBool("IsSliding", isSliding);
    }


    private void FixedUpdate()
    {
        //Chequeo del piso
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.02f, groundMask);
    }
}
