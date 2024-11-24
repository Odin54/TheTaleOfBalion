using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    public bool IsManaRegenUnabled()
    {
        if (PlayerStats.PlayerManaAmount <= PlayerStats.PlayerManaMax)
        {
            return true;
        }
        return false;
    }
    void Update()
    {
        if (IsManaRegenUnabled())
        {
            PlayerStats.PlayerManaAmount += PlayerStats.PlayerManaRegen * Time.deltaTime;
        }
        // Debug.Log(PlayerStats.PlayerManaAmount);
    }
}
