using UnityEngine;
using System.Collections;
public class WayPointScript1 : MonoBehaviour
{
    public Transform[] waypoint;
    public float speed = 5;
    // Update is called once per frame
    int currentWayPoint;
    Vector3 target, moveDirection;
    private bool flag = true;
    void Update()
    {
        target = waypoint[currentWayPoint].position;
        moveDirection = target - transform.position;
        if (moveDirection.magnitude < 1 && flag)
        {
            currentWayPoint = ++currentWayPoint % waypoint.Length;
            StartCoroutine(Stay());
        }
        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }
    IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(5);
        flag = true;
    }
}

