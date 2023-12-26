using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public TextMeshProUGUI scoreText; 
    
    void Update()
    {
        scoreText.text = playerPosition.position.z.ToString();
    }
}
