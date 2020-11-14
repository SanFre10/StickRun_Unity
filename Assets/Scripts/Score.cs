using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text TxtPrev;
    Text TxtActual;

    public static int Points;

    // Start is called before the first frame update
    void Start()
    { 
        if(GameObject.Find("Best") != null)
        {
            TxtPrev = GameObject.Find("Best").GetComponent<Text>();

            Debug.Log(Points);

            TxtPrev.text = Points.ToString();
            
        }
        else if(GameObject.Find("Score") != null)
        {
            TxtActual = GameObject.Find("Score").GetComponent<Text>();
        }
        InvokeRepeating("Sum",1,1);
    }

    // Update is called once per frame

    void Sum(){
        if(GameObject.Find("Score") != null)
        {
            Points = int.Parse(TxtActual.text) + 1;
            TxtActual.text = Points.ToString();
        }

    }
}
