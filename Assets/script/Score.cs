using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public TextMeshProUGUI scoreText; 
    
    void Update()
    {
        // Adding score to our game
        scoreText.text = (playerPosition.position.z + 98.3).ToString("0");
    }
}
