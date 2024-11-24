using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsBehaviour : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireShootFireStaff;
    public GameObject fireShootFrostStaff;

    private float fireStaffManaCost   = 10f;
    public float fireStaffAttackSpeed = 1.5f;
    // public Rigidbody2D rb;
    
    private float frostStaffManaCost  = 10f;

    float timeCurrent;
    float timeAtButtonDown;
    float timeAtButtonUp;
    float timeButtonHeld = 0;

    void Update()
    {
        timeCurrent = Time.fixedTime;
        if (PlayerStats.PlayerCurrentWeapon == "Fire Staff")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                timeAtButtonDown = timeCurrent;
                Debug.Log("Time current" + timeCurrent);
            }
            if (Input.GetButtonUp("Fire1"))
            {
                timeAtButtonUp = timeCurrent;
                timeButtonHeld = (timeAtButtonUp - timeAtButtonDown);
                Debug.Log("Time button pressed" + timeButtonHeld);
                if (timeButtonHeld > 0.7)
                {
                    timeButtonHeld = 0;
                    FireStaffShoot();
                }
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
