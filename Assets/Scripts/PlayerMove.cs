using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f;
    
    public Rigidbody p1;
    public Rigidbody p2;
    
    private Vector3 movement1;
    private Vector3 movement2;




    // Start is called before the first frame update
    void Start()
    {
        p1 = this.GetComponent<Rigidbody>();
        p2 = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement1 = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        //Input.GetButton("Horizontal");
    }
    

    void FixedUpdate()
    {
        move(movement1);
    }

    void move(Vector3 dir)
    {
        p1.AddForce(dir * speed);
        //p1.MovePosition(transform.position + (dir * (speed * Time.deltaTime)));
    }
}
