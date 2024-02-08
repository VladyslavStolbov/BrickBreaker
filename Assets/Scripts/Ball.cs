using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameManager _gameManager;
    private Rigidbody2D _rigidbody;
    private float _speed = 10f;
    private bool _isButtonPressed = false;
    private Vector3 _initialPosition;
    private Paddle _paddle;

    private void Awake()
    {
        _gameManager = GameManager.Instance;
        _rigidbody = GetComponent<Rigidbody2D>();
        _paddle = GameObject.FindGameObjectWithTag("Paddle").GetComponent<Paddle>();
        _initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !_isButtonPressed)
        {
            transform.SetParent(null);
            StartBall();
            _isButtonPressed = true;
        }
    }

    private void StartBall()
    {
        _rigidbody.AddForce(Vector2.up.normalized * _speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("BottomWall"))
        {
            ResetBall();
        }
    }

    public void ResetBall()
    {
        _rigidbody.velocity = Vector2.zero;
        _initialPosition.x = _paddle.transform.position.x;
        transform.SetParent(_paddle.transform);
        transform.position = _initialPosition;
        _gameManager.LoseLife();
        _isButtonPressed = false;
    }
}