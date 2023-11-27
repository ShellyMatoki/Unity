using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class FadeEffectScript : MonoBehaviour {
    public Text hellText;
    public float fadeSpeed = 10;
    public bool enterance=false;
    void Start () {
    //    hellText.color = Color.white;
    }
    void Update () {
        ColorChange();
    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "Player")  enterance = true;
    }
    void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player")  enterance = false;
     }
    private void ColorChange(){
      if (enterance)
        hellText.color = Color.Lerp(hellText.color, Color.red, fadeSpeed *Time.deltaTime);
      if (!enterance)
        hellText.color = Color.Lerp(hellText.color, Color.clear, fadeSpeed *Time.deltaTime);
    }
}

