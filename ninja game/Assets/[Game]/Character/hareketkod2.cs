using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketkod2 : MonoBehaviour
{
    float movementSpeed = 5.0f;
    CharacterController kontrol;
    public float jumpSpeed = 10.0f;
    public bool isGrounded = false;


    Animator animator;
    Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        kontrol = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
        movement = transform.TransformDirection(movement);
        movement *= movementSpeed;

        kontrol.Move(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            animator.SetTrigger("jump");
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("run");
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("run");
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (!Input.anyKey)
        {
            horizontalMovement = 0;
            verticalMovement = 0;
        }

        bool isIdle = (horizontalMovement == 0 && verticalMovement == 0);

        bool isRunning = (horizontalMovement != 0 || verticalMovement != 0);

        if (isIdle)
        {
            animator.SetBool("idle", true);
            animator.SetBool("run", false);
        }
        else if (isRunning)
        {
            animator.SetBool("idle", false);
            animator.SetBool("run", true);
        }



    }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Ground")
            { 
               isGrounded = true;   
            }
        }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }

    }


    }
