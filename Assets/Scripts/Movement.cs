using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float speed = 0.0f;
   
    void Start()
    {
        
    }


    void Update()
    
    {

        Vector2 pos = transform.position;
        pos.x += speed;
        pos.y += speed;

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.y += 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos.x += -1.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            pos.y += -1.0f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            pos.x += 1.0f;
        }

        transform.position = pos;
    }
    
}
