
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] States;

    private GameManager _gameManager;
    private SpriteRenderer _spriteRenderer;
    private int _health;

    private void Awake()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _health = States.Length;
    }

    private void Hit()
    {
        _health--;
        if (_health >= 0)
        {
            UpdateSprite();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void UpdateSprite()
    {
        _spriteRenderer.sprite = States[_health];
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            Hit();
            _gameManager.AddScore(10);
        }
    }
}