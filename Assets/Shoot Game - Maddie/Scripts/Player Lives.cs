using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public float zOffset = 1;
    public Image[] livesUI;
    public GameObject explosionPrefab;
    public GameObject screenFlash;
    public AudioSource hit;
    private GameObject cityscape;
    private GameObject burn1;
    private GameObject burn2;
    public GameObject burning;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hit = GetComponent<AudioSource>();
        cityscape = GameObject.Find("Cityscape");
        burn1 = GameObject.Find("Burn 1");
        burn2 = GameObject.Find("Burn 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Triggers explosion animation on collision with city and destroys the UFO
    //Makes the screen flash and decreases the life count by 1

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + zOffset ), Quaternion.identity);
            hit.Play();
            Destroy(collision.collider.gameObject);
            Instantiate(screenFlash, new Vector3(0, 0, 0), Quaternion.identity);
            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {  
                if(i < lives)
                {
                   
                    livesUI[i].enabled = true;
                }
                else
                {
                   
                    livesUI[i].enabled = false;
                }
            
            }
            //Triggers game over when all lives are lost
            if(lives <= 0)
            {
                Destroy(gameObject);
                Destroy(burn2);
                GameManagerShoot.instance.GameOver();
            }
            //Destroys game objects when lives lost to reveal burning city, activates smoke particles
            if(lives == 2)
            {
                Instantiate(burning, new Vector3(-15, -2, 1), Quaternion.identity);
                Destroy(cityscape);
            }
            if(lives == 1)
            {
                Instantiate(burning, new Vector3(12, -2, 1), Quaternion.identity);
                Instantiate(burning, new Vector3(6, -2, 1), Quaternion.identity);
                Destroy(burn1);
            }

        }
    }
}
