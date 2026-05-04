using UnityEngine;

public class FuelSpawner : MonoBehaviour
{
    [SerializeField] private float fuelSpawnTime = 3f;
    [SerializeField] private GameObject collectable;
    [SerializeField] private float collectRange = 0.3f;


    private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //Spawns a fuel pod at a set interval, timer counts up and resets when each fuel pod spawns
    void Update()
    {
        if (timer > fuelSpawnTime)
        {
           
            SpawnCollectable();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    //Instantiates a fuel pod at a random place in a predetermined range
    //Destroys collectable after 10 seconds

    private void SpawnCollectable()
    {
        Vector3 collectPos = transform.position + new Vector3(0, Random.Range(-collectRange, collectRange));
        GameObject collectableSpawned = Instantiate(collectable, collectPos, Quaternion.identity);

        Destroy(collectableSpawned, 10f);
    }

}
