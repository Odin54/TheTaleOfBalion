using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    private static float NeededStaminaAmplifier = 0.2f;
    private static float SprintStaminaAdjuster  = -15f;
    private static float RestStaminaAdjuster    = 20f;
    private static bool IsSprintIncreased       = false;

    public static bool IsPlayerSprintUsable()
    {
        if (PlayerStats.PlayerStaminaAmount > (PlayerStats.PlayerStaminaMax * NeededStaminaAmplifier))
        {
            return true;
        }
        return false;
    }

    public static void StaminaRest()
    {
        if (PlayerStats.PlayerStaminaAmount <= PlayerStats.PlayerStaminaMax)
        {
            PlayerStats.PlayerStaminaAmount += RestStaminaAdjuster * Time.deltaTime;
        }
        if (PlayerStats.PlayerStaminaAmount > PlayerStats.PlayerStaminaMax)
        {
            PlayerStats.PlayerStaminaAmount = PlayerStats.PlayerStaminaMax;
        }
    }

    public static void UseSprint()
    {
        if (PlayerStats.IsPlayerMoving)
        {
            if (PlayerStamina.IsPlayerSprintUsable())
            {
                PlayerStats.IsPlayerSprinting = true;
                if  (!IsSprintIncreased)
                {
                    IsSprintIncreased = true;
                    PlayerStats.MoveSpeed += PlayerMovement.MoveSpeedAdjuster;
                    PlayerMovement.RotationAnglePerSecond += PlayerMovement.RotationSpeedAdjuster;
                }
            }
        }
        PlayerStats.PlayerStaminaAmount += SprintStaminaAdjuster * Time.deltaTime;
    }

    public static void StopSprint()
    {
        PlayerStats.IsPlayerSprinting = false;
        if (IsSprintIncreased)
        {
            IsSprintIncreased = false;
            PlayerStats.MoveSpeed -= PlayerMovement.MoveSpeedAdjuster;
            PlayerMovement.RotationAnglePerSecond -= PlayerMovement.RotationSpeedAdjuster;
        }
    }

    void Update()
    {
        if (CurrentGameState.IsGameplayTurnedOn)
        {
            if (PlayerStats.IsPlayerSprinting)
            {
                if (PlayerStats.PlayerStaminaAmount > 0)
                {
                    UseSprint();
                }
                else
                {
                    StopSprint();
                }
            }
            else
            {
                StaminaRest();
            }
        }
    }
}
