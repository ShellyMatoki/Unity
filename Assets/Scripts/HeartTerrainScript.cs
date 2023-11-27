using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeartTerrainScript  : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalCoins = 0;
    public AudioClip sound;
/*    public Text hellText;
    private float fadeSpeed = 10;
    private bool enterance = false;*/
    public GameObject avatar;
    


    void Start()
    {
        
        GetComponent<Collider>().isTrigger = true;
        avatar.SetActive(false);

       // endText.color =  Color.clear;
    }

    // Update is called once per frame



    private void OnTriggerEnter(Collider c3d)
    {
        //sound.Play();
        Debug.Log("collision enter");
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c3d.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            totalCoins++;  
            Debug.Log("You currently have " + HeartTerrainScript.totalCoins + " Coins.");
            if (totalCoins == 5)
            {
               
             //   enterance = true;
                avatar.SetActive(true);
            }

            Destroy(gameObject);

        }
    }





}
