using System;
using UnityEngine;
using TMPro;

public class StaminaText: MonoBehaviour
{
  public TMP_Text staminaText;
  private int staminaPercents  = (int)Math.Round(PlayerStats.PlayerStaminaAmount);
  private float PercentageAmount = 100f;
  void Update()
  {
    staminaPercents  = (int)Math.Round(PlayerStats.PlayerStaminaAmount / PlayerStats.PlayerStaminaMax * PercentageAmount);
    staminaText.SetText("Stamina: " + staminaPercents + "%");
  }
}