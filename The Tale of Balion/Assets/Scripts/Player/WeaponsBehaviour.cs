using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsBehaviour : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireShootFireStaff;
    public GameObject fireShootFrostStaff;

    private float fireStaffManaCost   = 10f;
    private float frostStaffManaCost  = 10f;

    void Update()
    {
        if (PlayerStats.PlayerCurrentWeapon == "Fire Staff")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                FireStaffShoot();
            }
        }
        if (PlayerStats.PlayerCurrentWeapon == "Frost Staff")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                FrostStaffShoot();
            }
        }
    }

    void FireStaffShoot()
    {
        if (PlayerStats.PlayerManaAmount >= fireStaffManaCost)
        {
            PlayerStats.PlayerManaAmount -= fireStaffManaCost;
            Instantiate(fireShootFireStaff, firePoint.position, firePoint.rotation);
        }
    }
    void FrostStaffShoot()
    {
        if (PlayerStats.PlayerManaAmount >= frostStaffManaCost)
        {
            PlayerStats.PlayerManaAmount -= fireStaffManaCost;
            Instantiate(fireShootFrostStaff, firePoint.position, firePoint.rotation);
        }
    }
}
