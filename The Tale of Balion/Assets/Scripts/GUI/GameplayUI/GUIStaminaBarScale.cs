using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIStaminaBarScale : MonoBehaviour
{
    public Slider slider;
    private float PercentageAmount = 100f;

    public void SetStaminaValue()
    {
        slider.value = (int)Math.Round(PlayerStats.PlayerStaminaAmount / PlayerStats.PlayerStaminaMax * PercentageAmount);
    }

    void Update()
    {
        SetStaminaValue();
    }
}
