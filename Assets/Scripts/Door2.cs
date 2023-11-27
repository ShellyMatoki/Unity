using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    Animator anim;
/*    public GameObject leftdoor;
    public GameObject rightdoor;*/
    public GameObject gameObject;
    public GameObject gameObjectCube;
    private AudioSource sound;

    // private AudioSource sound;
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
        /*     IEnumerator ExampleCoroutine();
             yield return new WaitForSeconds(4);

             anim.SetInteger("OpenDoor", 3);*/
        gameObjectCube.SetActive(true);
       // ExampleCoroutine();


    }
   /* IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
      //  anim.SetBool("OpenDoor", false);
        gameObjectCube.SetActive(true);
    }*/
}
