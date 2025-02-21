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

        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float Incline = Vector3.Angle(MousePosition, transform.position);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Incline));



    }
}
