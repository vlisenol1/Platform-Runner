using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //movement
    private CharacterController controller;
    public float speed = 1f;

    //jump and gravity

    private Vector3 velocity;
    private float gravity= -9.81f;
    private bool isGround;

    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask groundLayer;

    public float jumpHeight = 0.1f;
    public float gravityDivide = 100f;
    public float jumpSpeed= 100;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //check character is grounded
        isGround = Physics.CheckSphere(groundChecker.position, groundCheckerRadius, groundLayer);


        //movement
        Vector3 moveInputs = Input.GetAxis("Horizontal") * Vector3.right + Input.GetAxis("Vertical") * Vector3.forward;
        Vector3 moveVelocity = moveInputs * Time.deltaTime * speed;


        controller.Move(moveVelocity);


        //jump and gravity
        
        if (!isGround)
        {
            velocity.y += gravity * Time.deltaTime / gravityDivide;
            speed = jumpSpeed;

        }
        else
        {
            velocity.y = -0.05f;
            speed = 10;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGround )
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity / gravityDivide);
        }


        controller.Move(velocity);

    }


}
