using System;
using UnityEngine;
using TMPro;

public class ManaText: MonoBehaviour
{
  public TMP_Text manaText;
  void Update()
  {
    manaText.SetText((int)Math.Round(PlayerStats.PlayerManaAmount) + "/" + (int)Math.Round(PlayerStats.PlayerManaMax));
  }
}