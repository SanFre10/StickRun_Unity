using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_manager : MonoBehaviour
{
    public float speed;
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
            rigidbody.velocity = new Vector2(-speed, 0);
        }
        else if (this.tag == "Floor")
        {
            transform.position = new Vector3(transform.position.x - speed*0.01f, transform.position.y, transform.position.z);

        }
        

        if (transform.position.x < -10)
        {
            if(this.tag == "Obstacle")
            {
                Destroy(this.gameObject);
            }
            else if(this.tag == "Floor")
            {
                transform.position = new Vector3(10, transform.position.y, transform.position.z);

            }

        }

    }
}
