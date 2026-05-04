using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroys game object - used as event in explosion animation
    public void DestroySelf()
    {
        Destroy(gameObject);
       
    }
}
