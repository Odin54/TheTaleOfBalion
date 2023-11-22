using UnityEngine;

public class Example : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float MoveSpeed;                  //5
    public float BackMoveSpeedAmplifier;     //0.7
    public float RotationAnglePerSecond;     //180

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.up * MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * MoveSpeed * BackMoveSpeedAmplifier * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, RotationAnglePerSecond) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -1 * RotationAnglePerSecond) * Time.deltaTime, Space.World);
        }
    }
}