using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class bullet : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.forward * speed;

    }
}
