using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Lives = 8;

    private SoundManager _soundManager;
    private BricksManager _bricksManager;
    private ScoreManager _scoreManager;
    [SerializeField] private GameObject _endGameScreen;
    [SerializeField] private TextMeshProUGUI _endGameText;
    [SerializeField] private Ball _ball;
    [SerializeField] private Paddle _paddle;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _bricksManager = BricksManager.Instance;
        _soundManager = SoundManager.Instance;
        _scoreManager = ScoreManager.Instance;
    }

    public void CheckGameState()
    {
        if (Lives <= 0)
        {
            GameOver();
        }
        else if (_bricksManager.IsCleared())
        {
            Win();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        _soundManager.PlaySound(_soundManager.LoseSound);
        _endGameScreen.SetActive(true);
        _endGameText.text = "Game Over";
        _endGameText.color = Color.red;
    }

    private void Win()
    {
        Time.timeScale = 0;
        _soundManager.PlaySound(_soundManager.WinSound);
        _endGameScreen.SetActive(true);
        _endGameText.text = "You Win";
        _endGameText.color = Color.green;
    }

    public void RestartGame()
    {
        _ball.ResetBall();
        Lives = 8;
        _scoreManager.ResetScore();
        _endGameScreen.SetActive(false);
        _paddle.ToInitialPosition();
        _bricksManager.ResetBricks();
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
