using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    Animator anim;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("OpenDoor", true);
        sound.PlayDelayed(0.3f);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("OpenDoor", false);

    }
    void Update()
    {
        
    }
}
