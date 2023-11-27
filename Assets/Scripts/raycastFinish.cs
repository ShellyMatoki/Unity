using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycastFinish : MonoBehaviour
{
    public Text hellText;
    public float fadeSpeed = 10;
    public bool enterance = false;

    public Transform target;
    public float moveSpeed = 6;
    public float rotationSpeed = 1;
    private int minDistance = 5; // אפשר להקטין 
                                 // private int safeDistance = 60;
                                 // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HeartTerrainScript.totalCoins == 5)
        {
            ColorChange();
            Vector3 direction = target.position - transform.position;

            direction.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
            if (direction.magnitude > minDistance)
            {
                Vector3 moveVector = direction.normalized * moveSpeed * Time.deltaTime;
                transform.position += moveVector;
            }
        }

    }

    private void ColorChange()
    {

        hellText.color = Color.Lerp(hellText.color, Color.red, fadeSpeed * Time.deltaTime);
    }
}