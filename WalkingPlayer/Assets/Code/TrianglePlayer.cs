﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianglePlayer : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D body;

    public float Speed;

    private void Awake()
    {
        trans = this.transform;
        trans = this.GetComponent<Transform>();
        body = this.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var movementDir = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movementDir += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movementDir += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movementDir += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movementDir += Vector2.right;
        }
        body.velocity = Speed * movementDir.normalized;
    }
}
