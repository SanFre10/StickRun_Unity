using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacles : MonoBehaviour
{
    public GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaculo, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
