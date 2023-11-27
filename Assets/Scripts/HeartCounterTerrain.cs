using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartCounterTerrain : MonoBehaviour
{
    
   
    // Start is called before the first frame update
    void Start()
    {
        HeartCounter.counterText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
        if (HeartCounter.counterText.ToString() != HeartScript.totalHeart.ToString())
        {
            HeartCounter.counterText.text = HeartScript.totalHeart.ToString();
        }
    }
}
