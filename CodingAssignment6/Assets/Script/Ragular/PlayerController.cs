using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //veriables that will hold speed and horizzontal/vertical movement
    public float Speed = 5f;
    private float xInput;
    private float yInput;

    Rigidbody rb;

    public GameObject wolf;
    float distanceToWolf;
    public float wolfDistThreshold;

    void Start()
    {
        //grabs the players rigidbody values at the start of the game
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        distanceToWolf = Vector3.Distance(transform.position, wolf.transform.position);
        //fills the verriables with the intput values
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");



       /* if (Input.GetKeyDown(KeyCode.Space))
        {
        }*/



        if (distanceToWolf <= wolfDistThreshold )
        {

            gotBit();
        }


    }

    private void FixedUpdate()
    {
        //calls walking in fixed update
        walking();
    }

    public void walking()
    {
        //math used for the player movement
        rb.AddForce(xInput * Speed, 0, yInput * Speed);
    }

    public void gotBit()
    {
        //sets player speed to zero
        Debug.Log("BARK!");
        Speed = 0;
    }
}
