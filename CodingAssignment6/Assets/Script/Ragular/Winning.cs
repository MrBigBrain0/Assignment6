using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject canvasObject;
    public GameObject Player;
    public GameObject pCamera;
    public GameObject mCamera;
    PlayerController playerController;

    private void Start()
    {
        
        if (canvasObject != null)
        {
            canvasObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            // Activate the canvas
            if (canvasObject != null)
            {
                Player.SetActive(false);
                mCamera.SetActive(true);
                canvasObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            if (canvasObject != null)
            {
                pCamera.SetActive(true);
                canvasObject.SetActive(false);
            }
        }
    }
}
