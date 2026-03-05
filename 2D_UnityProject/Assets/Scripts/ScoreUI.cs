using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int count = 0;
    
    public TextMeshProUGUI scoreText;
    
    public void AddScore()
    {
        count++;
        
        scoreText.text = count.ToString();
    }

}
