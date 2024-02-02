using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives { get; private set; }
    [SerializeField] private GameObject _gameOverScreen;
    public TMP_Text Text;
    public Health Health;

    private void Start()
    {
        Lives = 8;
    }

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

    private void Update()
    {
        Text.text = Score.ToString();
    }
}
