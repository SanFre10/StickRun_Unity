using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidrio : MonoBehaviour
{
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            var explosion = Instantiate(Explosion, this.transform.position, Quaternion.identity);
            Destroy(explosion, 3);
            
        }
        Destroy(this.gameObject);

    }
}
