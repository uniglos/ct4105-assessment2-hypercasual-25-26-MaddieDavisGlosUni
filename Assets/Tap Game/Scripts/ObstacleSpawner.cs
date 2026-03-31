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
    [SerializeField] private GameObject collectable;
    [SerializeField] private float collectRange = 0.3f;

    private float timer;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SpawnAsteroids();
        SpawnAsteroidsArray();
        
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            //SpawnAsteroids();
            SpawnAsteroidsArray();
            SpawnCollectable();
            timer = 0;
        }

        

        timer += Time.deltaTime;
       

    }

    private void SpawnAsteroids()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject asteroidBelt = Instantiate(asteroids, spawnPos, Quaternion.identity);

        Destroy(asteroidBelt, 10f);

    }

    private void SpawnAsteroidsArray()
    {
        int randomIndex = Random.Range(0, asteroidsArray.Length);
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(heightBottom, heightTop));
        GameObject asteroidArrayBelt = Instantiate(asteroidsArray[randomIndex], spawnPos, Quaternion.identity);

        Destroy(asteroidArrayBelt, 10f);
    }

    private void SpawnCollectable()
    {
        Vector3 collectPos = transform.position + new Vector3(0, Random.Range(-collectRange, collectRange));
        GameObject collectableSpawned = Instantiate(collectable, collectPos, Quaternion.identity);

        Destroy(collectableSpawned, 10f);
    }
}
