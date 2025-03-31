using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 5f;
    private float xInput;
    private float yInput;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb.AddForce(xInput * Speed, 0, yInput * Speed);
    }
}
