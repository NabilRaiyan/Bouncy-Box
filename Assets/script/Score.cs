using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // variable to get player position and text in GUI
    public Transform playerPosition;
    public TextMeshProUGUI scoreText; 
    
    void Update()
    {
        // Adding score to our game
        scoreText.text = (playerPosition.position.z + 98.3).ToString("0");
    }
}
