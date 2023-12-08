using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static Vector3 PlayerPositon;

    public static float MoveSpeed           = 5;
    public static float PlayerStaminaAmount = 100f;
    public static float PlayerStaminaMax    = 100f;
    public static float PlayerHealthAmount  = 100f;
    public static float PlayerHealthMax     = 100f;
    public static float PlayerManaAmount    = 100f;
    public static float PlayerManaMax       = 100f;

    public static bool IsPlayerSprinting    = false;
    public static bool IsPlayerMoving       = false;

    public static string PlayerCurrentWeapon       = "Hands";
}
