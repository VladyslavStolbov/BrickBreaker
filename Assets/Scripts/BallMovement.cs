using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _speed = 10f;
    private bool _isButtonPressed = false;
    private Vector3 _initialPosition;
    private PaddleMovement _paddle;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _paddle = GameObject.FindGameObjectWithTag("Paddle").GetComponent<PaddleMovement>();
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
        _initialPosition = _paddle.transform.position;
        transform.SetParent(_paddle.transform);
        transform.position = _initialPosition;
        _isButtonPressed = false;
    }
}


