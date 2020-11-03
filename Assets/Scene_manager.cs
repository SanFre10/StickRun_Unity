using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_manager : MonoBehaviour
{
    public float speed = 5;
    new Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Obstacle")
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (this.tag == "Background")
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }


        if (transform.position.x < -10)
        {
            if(this.tag == "Obstacle")
            {
                Destroy(this.gameObject);
            }
            if (this.tag == "Background")
            {
                transform.position = new Vector3(43.25f, transform.position.y, transform.position.z);
            }

        }

    }
}
