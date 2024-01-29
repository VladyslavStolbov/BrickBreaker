using System;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private GameObject Ball;
    
    private float _speed = 7f;
    private float _minX;
    private float _maxX;
    private float _maxBounceAngle = 75;
    
    private void Start()
    {
        float cameraWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;

        float halfPaddleWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2f;
        
        _minX = -cameraWidth / 2f + halfPaddleWidth;
        _maxX = cameraWidth / 2f - halfPaddleWidth;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        float newPosition = transform.position.x + horizontalInput * _speed * Time.deltaTime;
        
        float clampedPosition = Mathf.Clamp(newPosition, _minX, _maxX);

        transform.position = new Vector3(clampedPosition, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 paddlePosition = transform.position;
        Vector2 contactPoint = other.GetContact(0).point;

        float offset = paddlePosition.x - contactPoint.x;
        float width = other.otherCollider.bounds.size.x / 2;

        float currentAngle = Vector2.SignedAngle(Vector2.up, Ball.GetComponent<Rigidbody2D>().velocity);
        float bounceAngle = (offset / width) * _maxBounceAngle;
        float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -_maxBounceAngle, _maxBounceAngle);
        
        Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
        Ball.GetComponent<Rigidbody2D>().velocity =
            rotation * Vector2.up * Ball.GetComponent<Rigidbody2D>().velocity.magnitude;
    }
}
