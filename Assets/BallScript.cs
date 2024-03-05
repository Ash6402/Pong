using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    private Vector2 direction;
    private Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            rb.velocity = new Vector2(velocity.x, velocity.y * -1);
            return;
        }
        float yContact = other.gameObject.transform.InverseTransformPoint(other.GetContact(0).point).y;
        rb.velocity = new Vector2(velocity.x * -1,  yContact * 10);
    }
}
