using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] Sprites;

    private SpriteRenderer _spriteRenderer;
    private int _health;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _health = Sprites.Length;
    }

    private void Hit()
    {
        _health--;
        UpdateSprite();
        if (_health <= 0)
        {
            Destroy(this);
        }
    }

    private void UpdateSprite()
    {
        _spriteRenderer.sprite = Sprites[_health - 1];
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            Hit();
        }
    }
}