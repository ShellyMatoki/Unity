using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    private AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            sound.Play();
            Destroy(this.gameObject, 1);
        }
        
    }
}
