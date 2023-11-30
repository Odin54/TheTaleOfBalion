using System;
using UnityEngine;
using TMPro;

public class HealthText: MonoBehaviour
{
  public TMP_Text healthText;
  void Update()
  {
    healthText.SetText((int)Math.Round(PlayerStats.PlayerHealthAmount) + "/" + (int)Math.Round(PlayerStats.PlayerHealthMax));
  }
}