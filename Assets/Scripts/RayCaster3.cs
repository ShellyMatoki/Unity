using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class RayCaster3 : MonoBehaviour
{
    private float elevation = 20.0f;
   // Adjust this value to control the elevation of the raycast
                       //  public GameObject firstPersonController;


    void Update()
    {
        RaycastHit hit;
        Vector3 raycastStartPosition = transform.position + Vector3.up * elevation;
        Vector3 secondRaycastStartPosition = transform.position + Vector3.up * (elevation -10f);
        Debug.DrawRay(raycastStartPosition, transform.forward * 10, Color.green);



        if (Physics.Raycast(raycastStartPosition, transform.forward, out hit, 15) || Physics.Raycast(secondRaycastStartPosition, transform.forward, out hit, 15))
        {
            // Debug.Log("Hit");
            if (hit.collider.gameObject.name == "FirstPersonController")
            {
                Debug.Log("inside: " + HeartScript.totalHeart);
                HeartScript.totalHeart--;
                if (HeartScript.totalHeart == 0)
                    SceneManager.LoadScene(2);
                else
                {
                    hit.collider.transform.position = new Vector3(804f, 11f, 750f);
                    transform.position = new Vector3(519f, -0.8f, 420f);
                  


                }

            }
        }
/*
        Vector3 secondRaycastStartPosition = transform.position + Vector3.up * (elevation - 0.75f); // adjust the position of the second raycast
        Debug.DrawRay(secondRaycastStartPosition, transform.forward * 5, Color.red); // draw the second raycast in red
        if (Physics.Raycast(secondRaycastStartPosition, transform.forward, out hit, 15))
        {
            if (hit.collider.gameObject.name == "FirstPersonController")
            {
                HeartScript.totalHeart--;
                if (HeartScript.totalHeart == 0)
                    SceneManager.LoadScene(1);
            }
        }
*/
    }

}
