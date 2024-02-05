using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives = 8;

    private GameObject[] _initialBricks;

    [SerializeField] private GameObject _endGameScreen;
    [SerializeField] private TextMeshProUGUI _endGameText;
    [SerializeField] private BallMovement _ball;
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private GameObject[] _bricks;
    private void Update()
    {
        ScoreText.text = Score.ToString();
        CheckGameState();
    }
    public void AddScore(int amount)
    {
        Score += amount;
    }

    public void LoseLife()
    {
        Lives--;
    }

    private void CheckGameState()
    {
        if (Lives <= 0)
        {
            GameOver();
        }
        else if (IsCleared())
        {
            Win();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _endGameScreen.SetActive(true);
        _endGameText.text = "Game Over";
        _endGameText.color = Color.red;
    }

    private void Win()
    {
        Time.timeScale = 0;
        _endGameScreen.SetActive(false);
        _endGameText.text = "You Win";
        _endGameText.color = Color.green;
    }

    public void RestartGame()
    { 
        _ball.ResetBall();
        Lives = 8;
        Score = 0;
        _endGameScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private bool IsCleared()
    {
        if (_bricks.Length == 0)
        {
            return true;
        }

        return false;
    }

}
