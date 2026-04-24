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

  

    public void SetMaxFuel(float maxFuel)
    {
        MaxFuel = maxFuel;
    }

    public void ChangeFuel(float fuelLevel)
    {
        FuelLevel = fuelLevel;
        float newWidth = (FuelLevel / MaxFuel) * width;

        fuelBar.sizeDelta = new Vector2(newWidth, height);
    }

    public void StartFuel(float fuelStartLevel)
    {
        FuelStartLevel = fuelStartLevel;
        float startWidth = (FuelStartLevel / MaxFuel) * width;

        fuelBar.sizeDelta = new Vector2(startWidth, height);
    }
}
