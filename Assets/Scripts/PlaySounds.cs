using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    static AudioSource AudioSource;
    public static AudioClip Broken_glass;
    public static AudioClip game_over;
    public static AudioClip jump;
    public static AudioClip slide;

    public Stickman Jugador;
    void Start()
    {
        Broken_glass    = Resources.Load<AudioClip>("Broken_glass");
        game_over       = Resources.Load<AudioClip>("game_over");
        //jump            = Resources.Load<AudioClip>("jump");
        slide           = Resources.Load<AudioClip>("slide");

        AudioSource     = GetComponent<AudioSource>();

    }
    private void Update() {
        if(Jugador.isSliding == true){
            AudioSource.PlayOneShot(slide);
        }
        // else if(Jugador.rigidBody.velocity.y > 0.1){
        //     AudioSource.PlayOneShot(jump);
        // }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            AudioSource.PlayOneShot(Broken_glass);
        }
    }
}
