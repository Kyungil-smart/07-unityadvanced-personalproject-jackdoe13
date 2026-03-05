using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public GameOverUI gameOverUI;
    public ScoreUI scoreUI;

    public float time = 30f;
    public TMP_Text timerText;

    public GameObject GameOverPanel;
    
    public bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = 0;
            GameOver();
        }
        
        timerText.text = Mathf.Ceil(time).ToString();
        
    }

    public void GameOver()
    {
        isGameOver = true;

        gameOverUI.ShowGameOver(scoreUI.count);
        
        Time.timeScale = 0f;
    }
}
