using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerPosition.position.z);
    }
}
