using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int Score { get; private set; }

    private GameManager _gameManager;
    private const int ScoreIncrement = 10;
    [SerializeField] private TMP_Text ScoreText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _gameManager = GameManager.Instance;
    }

    public void AddScore(int amount)
    {
        Score += amount;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        Score = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        ScoreText.text = Score.ToString();
    }
}
