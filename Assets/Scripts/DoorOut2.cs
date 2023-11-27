using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOut2 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    /*    public GameObject leftdoor;
        public GameObject rightdoor;*/
    public GameObject gameObject;
    public GameObject gameObjectCube;
     private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
         sound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {

            gameObjectCube.SetActive(false);
            anim.SetBool("OpenDoor", true);
             sound.PlayDelayed(0.3f);
 
    }

    private void OnTriggerExit(Collider other)
    {
   
            anim.SetBool("OpenDoor", false);
          //  sound.PlayDelayed(0.3f);
            anim.SetInteger("OpenDoor", 3);
         //   ExampleCoroutine();
            gameObjectCube.SetActive(true);
   

    }
/*    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
       // anim.SetInteger("OpenDoor", 3);
        
    }*/
}
