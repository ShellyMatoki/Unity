using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellWallScript : MonoBehaviour
{
    public Text messageText;

    void Start()
    {
        // Hide the message initially when the game starts
        messageText.text = "";
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            // Display the message on the screen
            messageText.text = "Enter the cemetery!";
            // You can customize the message or add other interactions here
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Hide the message when the player is no longer colliding with the wall
            messageText.text = "";
        }
    }
}
