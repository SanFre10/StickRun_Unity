using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_manager : MonoBehaviour
{
    float speedR = 5;
    new Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("SpeedUp", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = speedR * Time.deltaTime;
        Debug.Log(speed);

        if (this.tag == "Obstacle" || this.tag == "Sierra" || this.tag == "Caja")
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (this.tag == "Background")
        {
            transform.position = new Vector3(transform.position.x - speed/100, transform.position.y, transform.position.z);
        }


        if (transform.position.x < -30)
        {
            if (this.tag == "Obstacle" || this.tag == "Sierra" || this.tag == "Caja")
            {
                Destroy(this.gameObject);
            }
            if (this.tag == "Background")
            {
                transform.position = new Vector3(43.25f, transform.position.y, transform.position.z);
            }

        }
    }
    void SpeedUp()
    {
        speedR += 1f;
    }
}
