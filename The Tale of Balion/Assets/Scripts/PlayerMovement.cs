using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public static float MoveSpeedAdjuster;
    public static float RotationSpeedAdjuster;

    public float BackMoveSpeedAmplifier;                 //0.7
    public static float RotationAnglePerSecond = 180;

    private bool IsPlayerSprintUsable = PlayerStamina.IsPlayerSprintUsable();

    void Start()
    {
        MoveSpeedAdjuster       = 5;
        RotationSpeedAdjuster   = 30;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
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
            transform.position += -transform.up * PlayerStats.MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * PlayerStats.MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * PlayerStats.MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += transform.up * PlayerStats.MoveSpeed * Time.deltaTime;
            PlayerStats.IsPlayerMoving  = false;
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
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (PlayerStats.IsPlayerSprinting)
            {
                PlayerStamina.StopSprint();
            }
        }
    }
}