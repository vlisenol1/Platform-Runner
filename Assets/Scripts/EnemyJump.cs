using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    private bool _alive;
    public float speed = 10.0f;
    //jump and gravity

    private Vector3 velocity;
    private float gravity = -9.81f;
    private bool isGround;

    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask groundLayer;

    public float jumpHeight = 0.1f;
    public float gravityDivide = 100f;
    public float jumpSpeed = 100;

    private void Start()
    {
        _alive = true;


    }


    private void FixedUpdate()
    {
        //check character is grounded
        isGround = Physics.CheckSphere(groundChecker.position, groundCheckerRadius, groundLayer);

        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }






        

        if ( isGround)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity / gravityDivide);
        }


        

    }


}
