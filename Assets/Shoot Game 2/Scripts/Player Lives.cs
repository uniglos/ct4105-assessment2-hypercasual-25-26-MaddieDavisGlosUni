using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public float zOffset = 1;
    public Image[] livesUI;
    public GameObject explosionPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + zOffset ), Quaternion.identity);
            Destroy(collision.collider.gameObject);
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
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
