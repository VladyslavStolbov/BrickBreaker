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
        Time.timeScale = 1;
        _gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        _gameOverScreen.SetActive(false);
        _ball.ResetBall();
        Lives = 8;
        Score = 0;
    }

    private void Update()
    {
        Text.text = Score.ToString();
    }
}
