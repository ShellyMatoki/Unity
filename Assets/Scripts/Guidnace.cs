using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guidnace : MonoBehaviour
{
    public Text guidance;
    public float fadeSpeed = 10;
    public bool enterance = false;
    void Start()
    {
        //    hellText.color = Color.white;
    }
    void Update()
    {
        ColorChange();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") enterance = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") enterance = false;
    }
    private void ColorChange()
    {
        if (enterance)
            guidance.color = Color.Lerp(guidance.color, Color.white, fadeSpeed * Time.deltaTime);
        if (!enterance)
            guidance.color = Color.Lerp(guidance.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


}
