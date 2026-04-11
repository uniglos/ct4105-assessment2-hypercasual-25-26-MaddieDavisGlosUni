using UnityEngine;
using UnityEngine.UI;

public class ChangeColour : MonoBehaviour
{
    [SerializeField] private Image barColour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        barColour = GetComponent<Image>();
    }

    public void ChangeColourRed()
    {
        
        barColour.color = Color.red;
    }

    public void ChangeColourGreen()
    {
        barColour.color = Color.green;

    }

}
