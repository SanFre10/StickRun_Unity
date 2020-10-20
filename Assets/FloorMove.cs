using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mueve el piso
        transform.position = new Vector3((float)(transform.position.x - 0.02), transform.position.y, transform.position.z);

        if(transform.position.x < -10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    }
}
