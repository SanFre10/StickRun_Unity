using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Stickman : MonoBehaviour
{
    Rigidbody2D rigidBody;
    Animator animator;
    public Transform groundCheck;
    public LayerMask groundMask;
    public LayerMask boxMask;

    public bool OutOfFrame = false;
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
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && isGrounded)
        {
            isSliding = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            rigidBody.velocity = new Vector2(-3f, rigidBody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            rigidBody.velocity = new Vector2(3f, rigidBody.velocity.y);
        }

        if(transform.position.x < -11)
        {
            OutOfFrame = true;
        }
        else
        {
            OutOfFrame = false;
        }

        //mainCamera.transform.position = new Vector3(transform.position.x + 5, mainCamera.transform.position.y, mainCamera.transform.position.z);

        //Control de las animaciones
        animator.SetBool("IsJumping", rigidBody.velocity.y > 0.1);
        animator.SetBool("IsSliding", isSliding);
    }


    private void FixedUpdate()
    {
        //Chequeo del piso
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.02f, groundMask);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Sierra")
        {
            EditorApplication.isPlaying = false;
        }
        //else if(col.gameObject.tag == "Caja")
        //{
        //    if(!Physics2D.OverlapCircle(groundCheck.position, 0.02f, boxMask)){
        //        EditorApplication.isPlaying = false;
        //    }
        //}
    }



}
