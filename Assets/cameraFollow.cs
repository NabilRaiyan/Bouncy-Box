
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset; // storing 3 floating point variable

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
