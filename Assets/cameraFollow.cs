
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; // vector3 is storing 3 floting point number

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
