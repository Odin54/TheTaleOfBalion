using UnityEngine;

public class Example : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        rb = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        moveSpeed = 4.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.up * moveSpeed * 0.7f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * 0.7f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * moveSpeed * 0.7f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 180f) * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -180f) * Time.deltaTime, Space.World);
        }
    }
}