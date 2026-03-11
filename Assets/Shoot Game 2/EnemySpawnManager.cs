using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemiesPrefab;
    [SerializeField] float spawnDelay = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.0f, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnEnemies()
    {
        Instantiate(enemiesPrefab, transform.position, Quaternion.identity);
    }
}
