using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //veriables that will hold speed and horizzontal/vertical movement
    public float Speed = 5f;
    private float xInput;
    private float yInput;
    float maxTime = 3;
    float timeElapsed;

    Rigidbody rb;

    //wolf info because I could not get it to work in the fsm tree but hey it works now
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
        //set up the wolf values so that if it gets close to the player the player will stop moving
        distanceToWolf = Vector3.Distance(transform.position, wolf.transform.position);

        //fills the verriables with the intput values
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if(timeElapsed >= maxTime)
        {
            Speed = 3;
            timeElapsed = 0;
        }

        //set ups a timer value
        timeElapsed += Time.deltaTime;

        //calls got bit if the wolf is in range
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
