using UnityEngine;

public class Health : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField] private Sprite[] _states;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _gameManager = GameManager.Instance;
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_gameManager.Lives > 0)
        {
            _spriteRenderer.sprite = _states[_gameManager.Lives - 1];
        }
    }
}
