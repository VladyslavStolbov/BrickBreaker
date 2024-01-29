using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _speed = 5f;
    private bool _isButtonPressed = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
}


