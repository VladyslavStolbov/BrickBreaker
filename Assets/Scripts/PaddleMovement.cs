using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private float _speed = 5f;
    private float _minX;
    private float _maxX;
    
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
}
