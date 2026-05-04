using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemiesPrefab;
    [SerializeField] float spawnDelay = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Allows enemies to spawn repeatedly at a set interval
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.0f, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Spawns enemies at the position of the spawn manager object
    private void SpawnEnemies()
    {
        Instantiate(enemiesPrefab, transform.position, Quaternion.identity);
    }
}
