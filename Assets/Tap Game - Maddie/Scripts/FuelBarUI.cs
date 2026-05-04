using UnityEngine;
using UnityEngine.UI;

public class FuelBarUI : MonoBehaviour
{
    public float FuelLevel;
    public float MaxFuel;
    public float FuelStartLevel;
    public float width;
    public float height;

    [SerializeField] private RectTransform fuelBar;
    [SerializeField] private Image barColour;

  
    //Copied from tutorial, not entirely sure how the fuel bar works

    //Sets the maxfuel value
    public void SetMaxFuel(float maxFuel)
    {
        MaxFuel = maxFuel;
    }

    //Changes the fuel bar width to match the fuel value
    public void ChangeFuel(float fuelLevel)
    {
        FuelLevel = fuelLevel;
        float newWidth = (FuelLevel / MaxFuel) * width;

        fuelBar.sizeDelta = new Vector2(newWidth, height);
    }
    //Sets the fuel bar to start at a certain width, to match the starting fuel level
    public void StartFuel(float fuelStartLevel)
    {
        FuelStartLevel = fuelStartLevel;
        float startWidth = (FuelStartLevel / MaxFuel) * width;

        fuelBar.sizeDelta = new Vector2(startWidth, height);
    }
}
