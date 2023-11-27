using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunScript : MonoBehaviour
{
   
   

    void Start()
    {

        GetComponent<Collider>().isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider c3d)
    {
        //sound.Play();

        //Destroy the coin if Object tagged Player comes in contact with it
        if (c3d.CompareTag("Player"))
        {         
          
            
            SceneManager.LoadScene(3);

        }
    }
}
