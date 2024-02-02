using UnityEngine;

public class Health : MonoBehaviour
{
    public GameManager GameManager;
    [SerializeField] private Sprite[] _states;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (GameManager.Lives > 0)
        {
            _spriteRenderer.sprite = _states[GameManager.Lives - 1];
        }
    }
}
