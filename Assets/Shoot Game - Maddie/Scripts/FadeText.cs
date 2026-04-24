using UnityEngine;

public class FadeText : MonoBehaviour
{
    public GameObject introText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(introText, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity); ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
