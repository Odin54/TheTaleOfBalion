using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIManaBarScale : MonoBehaviour
{
    public Slider slider;
    private float PercentageAmount = 100f;

    public void SetManaValue()
    {
        slider.value = (int)Math.Round(PlayerStats.PlayerManaAmount / PlayerStats.PlayerManaMax * PercentageAmount);
    }

    void Update()
    {
        SetManaValue();
    }
}
