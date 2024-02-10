using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int Score { get; private set; }

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
