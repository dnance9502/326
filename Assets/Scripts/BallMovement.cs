using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public float sped;
    public Rigidbody rb;

    private Vector3 _direction;
    private float _rand;

    
    void Start()
    {
        _rand = Random.Range(-1.0f, 1.0f);
        _direction = new Vector3(-1, 0, _rand);
        bool P1Start = true; //GetComponent<Goal>().p1start;
        //Debug.Log(P1Start);
        KickOff(P1Start, rb, _direction);
    }


    private void KickOff(bool player1, Rigidbody ball, Vector3 direction)
    {
        if (player1)
        {
            ball.AddForce(direction * speed * Time.deltaTime, ForceMode.Impulse);
        }
        else
        {
            ball.AddForce(-direction * speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("contact with wall");
            rb.AddForce(Reflect(rb.velocity.normalized) * Time.deltaTime * sped, ForceMode.Impulse);
            Debug.Log(rb.velocity);
        }

        else 
        {
            Debug.Log("contact with paddle");
            sped *= 1.2f;
            rb.AddForce(Reflect(rb.velocity.normalized) * Time.deltaTime * sped, ForceMode.Impulse);
            Debug.Log(rb.velocity);
            
        }
    }
    
    Vector3 Reflect(Vector3 direction)
    {
        return ((2 * Vector3.Dot(direction, direction.normalized) * direction.normalized) - direction);
    }
}
