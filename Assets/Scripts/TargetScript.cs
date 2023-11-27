using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class TargetScript : MonoBehaviour
{
    
      //[SerializeField] Transform target;
      NavMeshAgent agent;
      public GameObject target;
    // Vector3 old;
    private float old;
      public GameObject whenToStart;
      int num = 0;
   private Vector3 targetPos;
    private Vector3 transformtPos;
    // Start is called before the first frame update
    void Start()
      {

          agent = GetComponent<NavMeshAgent>();
          agent.enabled = true;
        //old = new Vector3(0, 0, 0);
        // agent.SetDestination(target.transform.position);
        targetPos = target.transform.position;
        transformtPos = transform.position;
        old = Vector3.Distance(transformtPos, targetPos);

      }

      // Update is called once per frame
      void Update()
      {

        targetPos = target.transform.position;
        transformtPos = transform.position;
        if (num == 0 && whenToStart.IsDestroyed())
          {
              agent.SetDestination(targetPos);
              num = 1;
          }
        
          //if (num == 1 && target.transform.position.x+10 > this.transform.position.x   && target.transform.position.z-10 < this.transform.position.z)
           else  if(num ==1 && Vector3.Distance(transformtPos, targetPos) !=old)   
           {


                     // old = target.transform.position;

                      agent.SetDestination(targetPos);
                    
             }
        old = Vector3.Distance(transformtPos, targetPos);
    }
  


    }



