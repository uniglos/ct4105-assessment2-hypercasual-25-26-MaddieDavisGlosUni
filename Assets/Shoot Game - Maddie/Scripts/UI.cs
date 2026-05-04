using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    
    //Restarts game - returns to shoot menu
     public void SceneLoader()
    {
        SceneManager.LoadScene("Shoot Variation");
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
