using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public Transform    Weapon;
    public GameObject   WeaponObject;
    public string WeaponName;
    private float weaponPosOffset       = -20f;
    private float weaponPickDistance    = 0.03f;
    private float distanceBetweenWeaponAndPlayer;

    void Update()
    {
       distanceBetweenWeaponAndPlayer = Vector3.Distance(PlayerStats.PlayerPositon, transform.position) + weaponPosOffset;
    }

    private void OnMouseDown()
    {
        // Debug.Log(distanceBetweenWeaponAndPlayer);
        if (distanceBetweenWeaponAndPlayer < weaponPickDistance)
        {
            PlayerStats.PlayerCurrentWeapon = WeaponName;
        }
    }
}