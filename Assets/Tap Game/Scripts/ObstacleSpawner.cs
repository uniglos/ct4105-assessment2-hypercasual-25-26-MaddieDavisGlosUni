using System.Threading;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject asteroids;

    private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnAsteroids();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            SpawnAsteroids();
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

}
