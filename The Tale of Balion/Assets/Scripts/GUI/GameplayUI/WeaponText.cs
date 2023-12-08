using System;
using UnityEngine;
using TMPro;

public class WeaponText: MonoBehaviour
{
  public TMP_Text weaponText;
  void Update()
  {
    weaponText.SetText(PlayerStats.PlayerCurrentWeapon);
  }
}