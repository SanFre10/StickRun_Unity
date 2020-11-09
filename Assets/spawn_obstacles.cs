using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_obstacles : MonoBehaviour
{
    public Stickman jugador;
    public System.Random rnd = new System.Random();
    public GameObject[] obs0;
    public GameObject[] obs1;
    public List <GameObject[]> allobs;
    public (int,int) current;
    // Start is called before the first frame update
    void Start()
    {
        current=(rnd.Next(0,1),-1);
        allobs=new List<GameObject[]>(){
            obs0,
            obs1
        };
        InvokeRepeating("Spawn", 2f, 2f);
    }


    public void Spawn()
    {
        //Decide si seguir con la progresion actual de prefabs o empezar de nuevo
        if(rnd.Next(0,2)==1){
            current=(current.Item1,current.Item2 == 2 ? 0 : current.Item2+1);
        }else{
            current=(rnd.Next(0,2),0);
        }
        GameObject obj = Instantiate(allobs[current.Item1][current.Item2], transform);
        obj.GetComponent<Scene_manager>().Jugador = jugador;
        Destroy(obj, 15);
    }
}
