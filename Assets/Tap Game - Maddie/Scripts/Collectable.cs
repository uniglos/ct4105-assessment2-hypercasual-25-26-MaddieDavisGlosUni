using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collectable : MonoBehaviour
{
    public AudioSource collectableAudio;
    //[SerializeField] private ParticleSystem fuelBurst;

    private void Start()
    {
        collectableAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collectableAudio.Play();
            //fuelBurst.Play();
            FuelManager.instance.IncreaseFuel();
            Destroy(gameObject);    

        }
    }

}