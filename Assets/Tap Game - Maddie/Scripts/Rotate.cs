using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float rotation = 50f;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    //Rotates game object 
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * rotation * Time.deltaTime, Space.World);
    }
}
