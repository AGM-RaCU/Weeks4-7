using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class Movement : MonoBehaviour
{
    float speed = 0.002f;

    // Start is called before the first frame update
=======
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float speed = 0.0f;
   
>>>>>>> Week-5-Coding-Gym
    void Start()
    {
        
    }

<<<<<<< HEAD
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
=======

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
    
>>>>>>> Week-5-Coding-Gym
}
