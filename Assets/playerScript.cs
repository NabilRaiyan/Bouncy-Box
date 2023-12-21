
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // variable for sideforce and forward force
    public Rigidbody rb;
    public float forwardForce = 2400f;
    public float sideForce = 500f;


    // Update is called once per frame
    void FixedUpdate()
    {
        // Time.deltatime means the time interval in seconds it took from the last frame to the current frame.
        // It measures the interval between the current frame and the last one
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // adding key event listener to left or right movement of player
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
