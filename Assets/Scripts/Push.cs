using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Push : MonoBehaviour
{
    private Vector3 velocity;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("RotatingPlatform"))
        {

            velocity.y = Mathf.Sqrt( 200f );

        }

    }
   




}
