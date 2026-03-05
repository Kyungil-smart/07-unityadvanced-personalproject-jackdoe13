using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text finalScoreText;

    public void ShowGameOver(int score)
    {
        finalScoreText.text = "Score : " + score;
        
        gameObject.SetActive(true);
    }
}
