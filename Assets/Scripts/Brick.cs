using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] States;

    private SoundManager _soundManager;
    private GameManager _gameManager;
    private ScoreManager _scoreManager;
    private SpriteRenderer _spriteRenderer;
    private int _health;

    private void Awake()
    {
        _soundManager = SoundManager.Instance;
        _gameManager = GameManager.Instance;
        _scoreManager = ScoreManager.Instance;
        _health = States.Length - 1;
    }

    private void Hit()
    {
        _soundManager.PlaySound(_soundManager.HitSound);
        _health--;
        if (_health < 0)
        {
            gameObject.SetActive(false);
            _gameManager.CheckGameState();
            return;
        }
        UpdateSprite();
    }

    private void UpdateSprite()
    {
        _spriteRenderer.sprite = States[_health];
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name != "Ball") return;
        Hit();
        _scoreManager.AddScore(10);
    }
}