using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    public float energy;
    public float maxEnergy;

    public Slider energySlider;
    public float increaseAmount = 0.04f;

    void Start()
    {
        energy = 0;
        maxEnergy = 1;

        energySlider.minValue = 0;
        energySlider.maxValue = maxEnergy;
        energySlider.value = energy;
    }

    void Update()
    {
        // On left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            IncreaseEnergy();
            if(energy >= maxEnergy)
            {
                Debug.Log("Energy Full!");
                energy = 0; // Reset energy after reaching max
                if (energySlider != null)
                    energySlider.value = energy;
            }
        }
    }

    void IncreaseEnergy()
    {
        energy += increaseAmount;
        energy = Mathf.Clamp(energy, 0, maxEnergy);
        // keeps value within min and max

        if (energySlider != null)
            energySlider.value = energy;
    }
}
