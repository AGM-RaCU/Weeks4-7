using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    float speed = 0.002f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 TankPosition = transform.position;


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            TankPosition.x -= speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            TankPosition.x += speed;
        }

        transform.position = TankPosition;
    }
}
