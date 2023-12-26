using UnityEngine;

public class playerCollsiionScript : MonoBehaviour
{
    // Checking collision with obstacle
    private void OnCollisionEnter(Collision collisionInfo)
    {
        // checking collision with obstacle
        if (collisionInfo.transform.tag == "obstacle")
        {
            Debug.Log("Hit");
        }
    }
}
