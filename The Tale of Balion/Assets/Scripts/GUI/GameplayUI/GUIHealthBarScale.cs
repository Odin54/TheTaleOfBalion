using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GUIHealthBarScale : MonoBehaviour
{
    public Slider slider;
    private float PercentageAmount = 100f;

    public void SetHealthValue()
    {
        slider.value = (int)Math.Round(PlayerStats.PlayerHealthAmount / PlayerStats.PlayerHealthMax * PercentageAmount);
    }

    void Update()
    {
        SetHealthValue();
    }
}
