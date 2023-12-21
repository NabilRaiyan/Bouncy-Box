using UnityEngine;

public class playerCollsiionScript : MonoBehaviour
{
    // Checking collision with obstacle
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.transform.name == "obstacle")
        {
            Debug.Log("Hit");
        }
    }
}
