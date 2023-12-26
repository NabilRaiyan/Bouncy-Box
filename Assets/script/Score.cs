using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public TextMeshProUGUI scoreText; 
    
    void Update()
    {
        Debug.Log(playerPosition.position.z);
    }
}
