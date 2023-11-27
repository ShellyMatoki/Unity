using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireBall : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(413.2f, 28.8f, 160.2f);
            HeartScript.totalHeart--;
            if (HeartScript.totalHeart <= 0)
                SceneManager.LoadScene(2);
        }
    }
}