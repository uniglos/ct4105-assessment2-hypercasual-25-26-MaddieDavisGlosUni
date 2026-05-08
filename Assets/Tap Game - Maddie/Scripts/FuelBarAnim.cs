using UnityEngine;

public class FuelBarAnim : MonoBehaviour
{
    public Animator fuelBarAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuelBarAnim = GetComponent<Animator>();
        fuelBarAnim.SetBool("collect", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFuelAnim()
    {
        fuelBarAnim.SetBool("collect", true);
    }
}
