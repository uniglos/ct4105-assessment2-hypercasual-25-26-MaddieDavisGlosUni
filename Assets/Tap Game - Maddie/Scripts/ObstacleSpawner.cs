using System.Threading;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private float heightTop = 15.0f;
    [SerializeField] private float heightBottom = 5.0f;
    [SerializeField] private GameObject asteroids;
    [SerializeField] private GameObject[] asteroidsArray;


    private float timer;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        SpawnAsteroidsArray();
        
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            
            SpawnAsteroidsArray();
            timer = 0;
        }
        

        timer += Time.deltaTime;
       

    }
    //Spawns asteroid prefab within a height range and destroys object after 10seconds
    private void SpawnAsteroids()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject asteroidBelt = Instantiate(asteroids, spawnPos, Quaternion.identity);

        Destroy(asteroidBelt, 10f);

    }
    //Spawns random asteroid prefab from array within a height range and destroys object after 10seconds
    private void SpawnAsteroidsArray()
    {
        int randomIndex = Random.Range(0, asteroidsArray.Length);
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(heightBottom, heightTop));
        GameObject asteroidArrayBelt = Instantiate(asteroidsArray[randomIndex], spawnPos, Quaternion.identity);

        Destroy(asteroidArrayBelt, 10f);
    }

    
}
