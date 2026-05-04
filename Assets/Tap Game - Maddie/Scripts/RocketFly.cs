using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fly : MonoBehaviour
{
    [SerializeField] private float velocity = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    public GameObject explosionPrefab;
    public AudioSource deathAudio;
    public AudioSource jumpAudio;
    public AudioSource collectAudio;
    [SerializeField] private ParticleSystem engineBurst;
    [SerializeField] private ParticleSystem collectBurst;
    [SerializeField] private FuelBarUI fuelBar;



    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        deathAudio = sources[0];
        jumpAudio = sources[1];
        collectAudio = sources[2];
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Pointer.current.press.wasPressedThisFrame == true)
        {
            jumpAudio.Play();
            rb.linearVelocity = Vector2.up * velocity;
            engineBurst.Play();
            FuelManager.instance.DecreaseFuel();
        }

    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * rotationSpeed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            
            collectAudio.Play();
            collectBurst.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

      

        deathAudio.Play();
        Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //Debug.Log("Waiting");
        StartCoroutine(GameManager.instance.DelayedGameOver(1));



    }



}
