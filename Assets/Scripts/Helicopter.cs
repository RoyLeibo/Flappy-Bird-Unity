﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public float upForce = 200f;
    public bool isDead = false;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead) return;
        if(Input.GetMouseButtonDown(0)){
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0,upForce));
        }
    }
    private void OnCollisionEnter2D() {
        isDead = true;
        rb2d.velocity = Vector2.zero;
    }
}