using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    public static bool P1Start = true;
    
    private Vector3 _direction;
    private float _rand;


    // Start is called before the first frame update
    void Start()
    {

        // set up random direction
        _rand = Random.Range(-1.0f, 1.0f);
        _direction = new Vector3(-1, 0, _rand);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        KickOff(P1Start);
    }
    
        private void KickOff(bool player1)
    {
        if (player1)
        {
            rb.AddForce(_direction.normalized * speed);  
        }
        else
        {
            rb.AddForce(-_direction.normalized * speed);
        }
        
    }

        
        private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("contact with wall");
        }

        if (other.gameObject.CompareTag("paddle"))
        {
            Debug.Log("contact with paddle");
            rb.AddForce(new Vector3(-_direction.x, 0, -_direction.z) * speed * 2);
        }
    }
}
