using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    //values that set hold the canvas, player, and camers
    public GameObject canvasObject;
    public GameObject Player;
    public GameObject pCamera;
    public GameObject mCamera;
    PlayerController playerController;

    private void Start()
    {
        //sets canvas to false if it was not already set to false.
        if (canvasObject != false)
        {
            canvasObject.SetActive(false);
        }
    }

    //when object with the tag player enters the triggered zone 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            // Activates the canvas if it null, turns on the main camera and disables the player
            if (canvasObject != null)
            {
                Player.SetActive(false);
                mCamera.SetActive(true);
                canvasObject.SetActive(true);
            }
        }
    }

    //when object with the tag player leaves the triggered area
    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            //turns on player camera and turns off canvas
            if (canvasObject != null)
            {
                Player.SetActive(true);
                pCamera.SetActive(true);
                canvasObject.SetActive(false);
            }
        }
    }
}
