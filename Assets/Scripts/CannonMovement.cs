using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        float mousePointer = mousePos.z;
       
        Vector3 rot = transform.eulerAngles;
        rot.z += mousePointer;
        
        transform.eulerAngles += rot;
    }
}
