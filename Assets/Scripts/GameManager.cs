using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
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
