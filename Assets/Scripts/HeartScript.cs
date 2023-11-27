using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class HeartScript  : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalHeart = 0;
    public AudioClip sound;
    
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
            AudioSource.PlayClipAtPoint(sound, transform.position);
            totalHeart++;  
            Debug.Log("You currently have " + HeartScript.totalHeart + " Hearts.");   
            Destroy(gameObject);
            //if(HeartScript.totalHeart==5)
             //   SceneManager.LoadScene(2);

        }
    }
}
