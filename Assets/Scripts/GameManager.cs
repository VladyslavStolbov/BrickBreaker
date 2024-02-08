using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Score { get; private set; }
    public int Lives = 8;

    private SoundManager _soundManager;
    private Brick[] _bricks;
    private bool _hasPlayedEndGameSound = false;

    [SerializeField] private GameObject _endGameScreen;
    [SerializeField] private TextMeshProUGUI _endGameText;
    [SerializeField] private Ball _ball;
    [SerializeField] private Paddle _paddle;
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private GameObject[] _brickRows;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        _soundManager = SoundManager.Instance;
    }

    private void Start()
    {
        AssignBricks();
    }

    private void Update()
    {
        CheckGameState();
    }

    public void AddScore(int amount)
    {
        Score += amount;
        ScoreText.text = Score.ToString(); ;
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
        if (!_hasPlayedEndGameSound)
        {
            _soundManager.PlaySound(_soundManager.LoseSound);
            _hasPlayedEndGameSound = true;
        }
        _endGameText.text = "Game Over";
        _endGameText.color = Color.red;
    }

    private void Win()
    {
        if (!_hasPlayedEndGameSound)
        {
            _soundManager.PlaySound(_soundManager.WinSound);
            _hasPlayedEndGameSound = true;
        }
        Time.timeScale = 0;
        _endGameScreen.SetActive(true);
        _endGameText.text = "You Win";
        _endGameText.color = Color.green;
    }

    public void RestartGame()
    {
        _ball.ResetBall();
        Lives = 8;
        Score = 0;
        _endGameScreen.SetActive(false);
        _paddle.ToInitialPosition();
        ResetBricks();
        Time.timeScale = 1;
        _hasPlayedEndGameSound = false; // Reset the flag when the game is restarted
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void ResetBricks()
    {
        foreach (var brick in _bricks)
        {
            brick.gameObject.SetActive(true);
        }
    }

    private bool IsCleared()
    {
        foreach (var brick in _bricks)
        {
            if (brick.gameObject.activeSelf)
            {
                return false;
            }
        }
        return true;
    }
    private void AssignBricks()
    {
        List<Brick> bricksList = new List<Brick>();
        foreach (var row in _brickRows)
        {
            foreach (Transform brick in row.transform)
            {
                bricksList.Add(brick.GetComponent<Brick>());
            }
        }
        _bricks = bricksList.ToArray();
    }

}
