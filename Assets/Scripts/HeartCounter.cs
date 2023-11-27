using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class HeartCounter : MonoBehaviour
{
    public static Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != HeartScript.totalHeart.ToString())
        {
            counterText.text = HeartScript.totalHeart.ToString();
           // GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }
}

/*[Serializable]
public class HeartCounter : MonoBehaviour
{


     public Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (counterText.text != HeartScript.totalHeart.ToString())
        {
            MySaveDataScript.Save();
        }
    }

}*/

