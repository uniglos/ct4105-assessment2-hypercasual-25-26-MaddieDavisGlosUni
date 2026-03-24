using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject explosionPrefab;
    private PointManager pointManager;
    public AudioSource source;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointManager = GameObject.Find("Point Manager").GetComponent<PointManager>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            source.Play();
            Destroy(collision.gameObject);
            pointManager.UpdateScore(10);
            //Destroy(gameObject);        
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
