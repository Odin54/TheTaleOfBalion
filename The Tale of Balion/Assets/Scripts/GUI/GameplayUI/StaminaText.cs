using System;
using UnityEngine;
using TMPro;

public class StaminaText: MonoBehaviour
{
  public TMP_Text staminaText;
  void Update()
  {
    staminaText.SetText((int)Math.Round(PlayerStats.PlayerStaminaAmount) + "/" + (int)Math.Round(PlayerStats.PlayerStaminaMax));
  }
}