using UnityEngine;

public class FuelBarAnim : MonoBehaviour
{
    public Animator animator;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("collect", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFuelAnim()
    {
        animator.SetBool("collect", true);
    }

    public void SetFalse()
    {
        animator.SetBool("collect", false);
    }
}

