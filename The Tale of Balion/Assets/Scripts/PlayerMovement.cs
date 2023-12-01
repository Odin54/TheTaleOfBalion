using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public static float MoveSpeedAdjuster;
    public static float MoveSpeedBackAdjuster;
    public static float RotationSpeedAdjuster;

    public static float RotationAnglePerSecond = 180;

    private bool IsPlayerSprintUsable = PlayerStamina.IsPlayerSprintUsable();
    private bool IsBackMoveUsed       = false;

    public Animator animator;
    void Start()
    {
        MoveSpeedAdjuster       = 5;
        MoveSpeedBackAdjuster   = -2;
        RotationSpeedAdjuster   = 30;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void BackMoveUse()
    {
        if (!IsBackMoveUsed)
        {
            IsBackMoveUsed = true;
            PlayerStats.MoveSpeed += MoveSpeedBackAdjuster;
            Debug.Log(PlayerStats.MoveSpeed + " 11");
        }
    }


    private void BackMoveCancelUse()
    {
        if (IsBackMoveUsed)
        {
            IsBackMoveUsed = false;
            PlayerStats.MoveSpeed -= MoveSpeedBackAdjuster;
        }
    }

    void Update()
    {
        if (CurrentGameState.IsGameplayTurnedOn)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = true;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = false;
            }

            if (Input.GetKey(KeyCode.S))
            {
                BackMoveUse();
                transform.position += -transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving = true;
                IsBackMoveUsed  = true;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                BackMoveUse();
                transform.position += transform.right * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = true;
                IsBackMoveUsed  = true;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                BackMoveUse();
                transform.position += -transform.right * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = true;
                IsBackMoveUsed  = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
                PlayerStats.IsPlayerMoving  = false;
            }

            if (!PlayerStats.IsPlayerMoving)
            {
                animator.SetFloat("Speed", 0);
            }
            else
            {
                Debug.Log(PlayerStats.MoveSpeed);
                animator.SetFloat("Speed", PlayerStats.MoveSpeed);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(new Vector3(0, 0, RotationAnglePerSecond) * Time.deltaTime, Space.World);
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(new Vector3(0, 0, -1 * RotationAnglePerSecond) * Time.deltaTime, Space.World);
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (PlayerStats.IsPlayerMoving)
                {
                    PlayerStamina.UseSprint();
                }
                if (!PlayerStats.IsPlayerSprinting)
                {
                    PlayerStamina.StaminaRest();
                }
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                if (PlayerStats.IsPlayerSprinting)
                {
                    PlayerStamina.StopSprint();
                }
            }

            if (!Input.GetKeyDown(KeyCode.S))
            {
                if (!Input.GetKeyDown(KeyCode.A))
                {
                    if (!Input.GetKeyDown(KeyCode.D))
                    {
                        BackMoveCancelUse();
                    }
                }   
            }
        }
    }
}