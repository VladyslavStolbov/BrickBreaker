using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives;
    public TMP_Text Text;

    public void AddScore(int amount)
    {
        Score += amount;
    }

    private void Update()
    {
        Text.text = Score.ToString();
    }
}
