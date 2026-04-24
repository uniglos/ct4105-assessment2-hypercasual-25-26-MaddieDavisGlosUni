using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AsteroidIncreaseScore : MonoBehaviour
{
    public AudioSource collectPoint;

    private void Start()
    {
        collectPoint = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectPoint.Play();
            Score.instance.UpdateScore();
            
        }
    }

}
