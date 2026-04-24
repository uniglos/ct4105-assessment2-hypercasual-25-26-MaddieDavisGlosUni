using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FuelManager : MonoBehaviour
{
    public static FuelManager instance;

    public float Fuel;
    public float MaxFuel;
    [SerializeField] private FuelBarUI fuelBar;
    [SerializeField] private ChangeColour barColour;

    [SerializeField] private TextMeshProUGUI currentFuelText;

    private int fuel = 20;
    [SerializeField] int fuelValue = 10;
    [SerializeField] int maxFuelValue = 40;
    public GameObject flashRed;
    public GameObject currentFlash;
    private bool flashing = false;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuelBar.SetMaxFuel(MaxFuel);
        fuelBar.StartFuel(fuel);
        currentFuelText.text = fuel.ToString();
        currentFlash = Instantiate(flashRed, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (fuel <= 10 && !flashing)
        {
            barColour.ChangeColourRed();
            flashing = true;
            currentFlash.SetActive(true);
           
        }
        if (fuel >= 11)
        {
            barColour.ChangeColourGreen();
           currentFlash.SetActive(false);
           flashing = false;
        }
        if (fuel == 0)
        {
            GameManager.instance.GameOver();
        }
    }
    public void DecreaseFuel()
    {
        fuel --;
        ChangeFuel(-1f);
        currentFuelText.text = fuel.ToString();
    }

    public void IncreaseFuel()
    {
        ChangeFuel(fuelValue);
        fuel += fuelValue;
        if (fuel >= maxFuelValue)
        {
            fuel = maxFuelValue;
        }
        currentFuelText.text = fuel.ToString();
    }

    public void ChangeFuel(float fuelChange)
    {
        Fuel += fuelChange;
        Fuel = Mathf.Clamp(Fuel, 0, MaxFuel);

        fuelBar.ChangeFuel(Fuel);
    }
}
