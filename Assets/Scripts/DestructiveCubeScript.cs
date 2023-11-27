using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class DestructiveCubeScript : MonoBehaviour
{
    public GameObject remains;


    void Update()
    {
        if (GunFire.amountDestroy[0]==1&& GunFire.amountDestroy[1]==1&& GunFire.amountDestroy[2]==1&& GunFire.amountDestroy[3]==1)
        {

            Instantiate(remains, new Vector3(641f, 84f, 290f), transform.rotation);
            Destroy(gameObject);
            
        }

    }

 

}
