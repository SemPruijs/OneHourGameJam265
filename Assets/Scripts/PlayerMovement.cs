using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    private float _moveHorizontal;
    private float _moveVertical;
    private float _rotate;

    private float _rotation;
    
    public Vector2 movement;
    
    public float moveSpeed;
    public float rotationSpeed;
    
    //data
    private Rigidbody2D _rb2d;
    
    
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
        _rotate = Input.GetAxis("Rotate");
        
        
        movement = new Vector2 (_moveHorizontal, _moveVertical);
    }

    private void FixedUpdate()
    {
        _rb2d.AddForce (movement * moveSpeed);
        _rotation += _rotate * rotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, _rotation);
    }
}
