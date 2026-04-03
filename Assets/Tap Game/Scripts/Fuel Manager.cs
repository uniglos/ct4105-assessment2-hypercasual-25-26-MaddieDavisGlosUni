using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FuelManager : MonoBehaviour
{
    public static FuelManager instance;

    [SerializeField] private TextMeshProUGUI currentFuelText;

    private int fuel = 20;
    [SerializeField] int fuelValue = 10;
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
        currentFuelText.text = fuel.ToString();
        currentFlash = Instantiate(flashRed, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (fuel <= 10 && !flashing)
        {
            
            flashing = true;
            currentFlash.SetActive(true);
        }
        if (fuel >= 11)
        {
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
        currentFuelText.text = fuel.ToString();
    }

    public void IncreaseFuel()
    {
        fuel += fuelValue;
        currentFuelText.text = fuel.ToString();
    }
}
