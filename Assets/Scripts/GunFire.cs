using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GunFire : MonoBehaviour
{
    public GameObject gun;
    public GameObject target;
    public GameObject start_point;
    public GameObject aCamera;
    LineRenderer line;
    AudioSource gun_sound;
    public static  int[] amountDestroy= new int [6];


  //  public static NavMeshAgent[] navMeshWarrior;


  //  public GameObject warrior;

    public  Transform[] warrior;
 

    void Start()
    {
        line = gun.GetComponent<LineRenderer>();
        gun_sound = gun.GetComponent<AudioSource>();
        for (int i = 0; i < 6; i++)
        {
            amountDestroy[i] = 0;

        }


     
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = (1 << 8); 
        if (Input.GetKeyDown(KeyCode.Z))
        {
                if (gun.gameObject.activeSelf)
                {
                    RaycastHit hit;
                    if (Physics.Raycast(aCamera.transform.position, aCamera.transform.forward, out hit,Mathf.Infinity, layerMask))

                //Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
                {
                    /*target.transform.position = hit.point;
                    StartCoroutine(Fire());*/
                    for (int i = 0; i < 6; i++)
                        {
                             Debug.Log(i.ToString());
                             target.transform.position = hit.point;
                             StartCoroutine(Fire());

                        //     if(!(warrior[i].IsDestroyed()))
                    if(!(warrior[i].IsDestroyed())&& amountDestroy[i]==0)
                        {

                            if (hit.collider.gameObject == warrior[5].gameObject)
                                SceneManager.LoadScene(4);

                            else if ( hit.collider.gameObject == warrior[i].gameObject)
                                    {

                                      Debug.Log("fd "+i.ToString());
                                      NavMeshAgent agent = warrior[i].GetComponent<NavMeshAgent>();
                                         //// agent.enabled = false;
                                        Animator a = warrior[i].GetComponent<Animator>();
                                        a.SetInteger("Status", 3);
                               
                                        Destroy(warrior[i].gameObject, 3f);
                                      
                                        amountDestroy[i]=1;
                                    

                                    }

                        }
                        
                        


                        }

                    }
                }
        }
    }

    IEnumerator Fire()
    {
        line.enabled = true;
        line.material.color=Color.yellow;
        line.SetPosition(0, start_point.transform.position);
        line.SetPosition(1, target.transform.position);
        gun_sound.Play();
        
        yield return new WaitForSeconds(0.2f);
        target.transform.position = new Vector3(0.0f, -400.0f, 0.0f);
        line.enabled = false;
    }

   /* public static void setDestEnemies()
    {
        for (int i = 0; i < 5; i++)
        {
            if (navMeshWarrior[i].gameObject.IsDestroyed == false)
                navMeshWarrior[i].SetDestance();
        }
    }*/
}
