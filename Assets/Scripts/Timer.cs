using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    public string LevelToLoad0;
    public string LevelToLoad1;
    private float timer = 15f;
    private Text timerSeconds;


    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            if ( HeartScript.totalHeart.ToString()=="0")
                Application.LoadLevel(LevelToLoad0);
            else
            {
            
                Application.LoadLevel(LevelToLoad1);

            }
        }

    }
}