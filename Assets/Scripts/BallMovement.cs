using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _speed = 1f;
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
            _isButtonPressed = true;
        }

        if (_isButtonPressed)
        {
            BallMove();
        }
    }

    private void BallMove()
    {
        _rigidbody.AddForce(Vector2.up.normalized * _speed, ForceMode2D.Impulse);
    }
}
