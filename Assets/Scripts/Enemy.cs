using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10.0f;
    private bool _alive;

    
    

    private void Start()
    {
        _alive = true;
       
       
    }

    private void FixedUpdate()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        
      

    }

    


}
