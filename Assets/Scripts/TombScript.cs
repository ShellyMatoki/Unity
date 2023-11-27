using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TombScript : MonoBehaviour
{
    // Start is called before the first frame update

    private AudioSource sound;
 

    void Start()
    {
        sound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*    void OnTriggerEnter(Collider c3d)
        {

            sound.Play();

        }

        private void OnTriggerExit(Collider other)
        {
            sound.Stop();

        }*/

    private void OnCollisionEnter(Collision collision)
    {
        sound.Play();

    }

    private void OnCollisionExit(Collision collision)
    {
        sound.Stop();
    }

}
