using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowScript : MonoBehaviour
{
    // Start is called before the first frame update


    void Update()
    {
        // This casts a ray that ignores both layers 2 and 8:
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int layerMask = (1 << 8);  // (1 << 2) | (1 << 8);
                                   // layerMask = ~layerMask;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // some code if the ray hits
            hit.collider.GetComponent<Renderer>().material.color = Color.green;
        }
    }

}
