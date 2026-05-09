using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collectable : MonoBehaviour
{
    public AudioSource collectableAudio;
    private Animator animator;
    private bool playing;
   

    private void Start()
    {
        collectableAudio = GetComponent<AudioSource>();
        animator = GameObject.Find("Fuel Bar").GetComponent<Animator>();
        animator.SetBool("collect", false);
        //playing = false;

    }

    private void Update()
    {
        //if(playing)
        {
           // animator.SetBool("collect", false);
            //playing = false;
        }
    }

    //On collision with player the fuel increase and collectable is destroyed
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            animator.SetBool("collect", true);
            //playing = true;
            FuelManager.instance.IncreaseFuel();
            Destroy(gameObject);    

        }
    }


  

}