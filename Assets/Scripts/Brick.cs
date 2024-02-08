using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] States;

    private GameManager _gameManager;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _bottomWall;
    private int _health;

    private void Awake()
    {
        _gameManager = GameManager.Instance;
        _health = States.Length - 1;
    }

    private void Hit()
    {
        _health--;
        if (_health < 0)
        {
            gameObject.SetActive(false);
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
        _gameManager.AddScore(10);
    }
}