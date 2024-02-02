using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives { get; private set; }
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
        Debug.Log("Game Over");
    }

    private void Update()
    {
        Text.text = Score.ToString();
    }
}
