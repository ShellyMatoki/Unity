using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimzoCSScript : MonoBehaviour
{
    void Start() { }
    void Update() { }
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "WayPoint.tif");
    }
}

