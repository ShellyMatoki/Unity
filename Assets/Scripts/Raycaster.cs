using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Raycaster : MonoBehaviour
{
    public float elevation = 2.0f; // Adjust this value to control the elevation of the raycast
  //  public GameObject firstPersonController;
    void Update()
    {
        RaycastHit hit;
        Vector3 raycastStartPosition = transform.position + Vector3.up * elevation;
        Debug.DrawRay(raycastStartPosition, transform.forward * 5, Color.green);

        

        if (Physics.Raycast(raycastStartPosition, transform.forward, out hit,15))
        {
           // Debug.Log("Hit");
            if (hit.collider.gameObject.name == "FirstPersonController")
            {
                hit.collider.transform.position = new Vector3(413.2f, 28.8f, 160.2f);   
                
                Debug.Log("inside: " + HeartScript.totalHeart);
                HeartScript.totalHeart--;
                if (HeartScript.totalHeart<=0)
                    SceneManager.LoadScene(2);
                
            }
        }

  /*      Vector3 secondRaycastStartPosition = transform.position + Vector3.up * (elevation-0.75f); // adjust the position of the second raycast
        Debug.DrawRay(secondRaycastStartPosition, transform.forward * 5, Color.red); // draw the second raycast in red
        if (Physics.Raycast(secondRaycastStartPosition, transform.forward, out hit, 15))
        {
            if (hit.collider.gameObject.name == "shadow")
            {
                HeartScript.totalHeart--;
                if (HeartScript.totalHeart == 0)
                    SceneManager.LoadScene(1);
            }
        }*/
    }

}