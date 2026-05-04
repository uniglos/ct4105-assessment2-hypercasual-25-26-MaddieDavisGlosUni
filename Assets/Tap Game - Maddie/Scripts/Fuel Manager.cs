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
    //Plays screen flash animation when the fuel is below 10 (unless already playing)
    //Calls function to change the bar to red when below 10
    void Update()
    {
        if (fuel <= 10 && !flashing)
        {
            barColour.ChangeColourRed();
            flashing = true;
            currentFlash.SetActive(true);
           
        }
        //Stops falsh and goes back to green when fuel goes above 10 again
        if (fuel >= 11)
        {
            barColour.ChangeColourGreen();
           currentFlash.SetActive(false);
           flashing = false;
        }
        //Triggers game over if fuel reaches 0
        if (fuel == 0)
        {
            GameManager.instance.GameOver();
        }
    }
    //Deceases the fuel count by 1, updates both fuel bar and fuel number in UI
    public void DecreaseFuel()
    {
        fuel --;
        ChangeFuel(-1f);
        currentFuelText.text = fuel.ToString();
    }
    //Increases the fuel by a set value, but will not let the fuel go above a set maximum
    //Updates both fuel bar and fuel number in UI
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

    //Changes the fuel number for fuel bar 
    //Calls function to change the fuel bar graphic
    //Followed a tutorial, I'm not entirely sure how it works
    public void ChangeFuel(float fuelChange)
    {
        Fuel += fuelChange;
        Fuel = Mathf.Clamp(Fuel, 0, MaxFuel);

        fuelBar.ChangeFuel(Fuel);
    }
}
