using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] private float Speed = 5f; // Speed of the player movement
    private float H_Input; // Horizontal input value
    private float V_Input; // Vertical input value
    private Rigidbody RB; // Reference to the Rigidbody2D component


    private void Start()
    {
        RB = GetComponent<Rigidbody>(); // Get the Rigidbody2D component attached to the player
    }

    private void FixedUpdate()
    {
        H_Input = Input.GetAxis("Horizontal"); // Get the horizontal input value
        V_Input = Input.GetAxis("Vertical"); // Get the vertical input value
        Vector3 movement = new Vector3(H_Input, 0f, V_Input).normalized; // Create a movement vector based on input and normalize it
        RB.MovePosition(RB.position + movement * Speed * Time.fixedDeltaTime); // Move the player based on the movement vector, speed, and delta time
    }
}
