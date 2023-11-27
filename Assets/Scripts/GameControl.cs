using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    //Data to persist
   

    void Awake()
    {
        this.transform.position = new Vector3(446, -16, 230);
        //Let the gameobject persist over the scenes
        DontDestroyOnLoad(gameObject);
    }

}

