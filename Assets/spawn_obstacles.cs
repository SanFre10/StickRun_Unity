using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacles : MonoBehaviour
{
    public GameObject obs1;
    public GameObject obs12;
    public GameObject obs13;
    public GameObject obs14;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(obs12, transform);
    }
}
