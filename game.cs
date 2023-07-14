using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;    // Speed of the car
    public float rotationSpeed = 100f;   // Rotation speed of the car

    private Rigidbody rb;   // Rigidbody component of the car

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveForward = Input.GetAxis("Vertical");    // Get input for forward/backward movement
        float rotate = Input.GetAxis("Horizontal");    // Get input for rotation

        // Move the car forward/backward
        rb.AddRelativeForce(Vector3.forward * moveForward * speed);

        // Rotate the car
        rb.rotation *= Quaternion.Euler(Vector3.up * rotate * rotationSpeed * Time.fixedDeltaTime);
    }
}