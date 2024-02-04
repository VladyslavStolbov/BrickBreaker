using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives = 8;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private BallMovement _ball;
    public TMP_Text Text;

    public void AddScore(int amount)
    {
        Score += amount;
    }

    public void LoseLife()
    {
        Lives--;
        if (Lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    { 
        _ball.ResetBall();
        Lives = 8;
        Score = 0;
        _gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        Text.text = Score.ToString();
    }
}
