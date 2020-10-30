using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacles : MonoBehaviour
{
    public GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn(obstaculo)", 2f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(GameObject obstaculo)
    {
        Instantiate(obstaculo, transform);
    }
}
