using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float speed = 0.002f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Position.x -= speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Position.x += speed;
        }

        transform.position = Position;
    }

  