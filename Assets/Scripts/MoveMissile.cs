using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMissile : MonoBehaviour {

    Rigidbody2D rb;
    bool movingRight = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 7)
            movingRight = false;
        if (transform.position.x < -7)
            movingRight = true;
	}

    void FixedUpdate()
    {
        if (movingRight)
            moveRight();
        else
            moveLeft();
    }

    void moveRight()
    {
        transform.localEulerAngles = new Vector3(0f, 180f, 0f);
        rb.velocity = new Vector2(5f, 0f);
    }

    void moveLeft()
    {
        transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        rb.velocity = new Vector2(-5f, 0f);
    }
}
