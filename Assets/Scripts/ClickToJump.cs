using UnityEngine;

public class ClickJump : MonoBehaviour
{
    public float jumpForce = 500f; // Adjust this value in the Inspector

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        // Apply an upward force to make the object jump
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}