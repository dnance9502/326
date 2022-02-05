using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody player;

    
    void Start()
    {
        player = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (this.CompareTag("player1"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                Transform transform1 = player.GetComponent<Transform>();
                transform1.position += Vector3.forward * speed * Time.deltaTime;
                //Rigidbody rb = GetComponent<Rigidbody>();
                //Vector3 move = Vector3.forward * speed * Time.deltaTime;
                //player.AddForce(move, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.S))
            {
                Transform transform1 = player.GetComponent<Transform>();
                transform1.position += Vector3.back * speed * Time.deltaTime;
                //Rigidbody rb = GetComponent<Rigidbody>();
                //Vector3 move = Vector3.back * speed * Time.deltaTime;
                //player.AddForce(move, ForceMode.VelocityChange);
            }

        }

        if (this.CompareTag("player2"))
        {
            if (Input.GetKey(KeyCode.I))
            {
                Transform transform2 = player.GetComponent<Transform>();
                transform2.position += Vector3.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.K))
            {
                Transform transform2 = player.GetComponent<Transform>();
                transform2.position += Vector3.back * speed * Time.deltaTime;
            }

        }
    }
    
}
