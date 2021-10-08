using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scr_PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    [Header("Player Movement")]
    public float horizontalForce;
    [Range(0.0f, 0.99f)]
    public float slowingFactor;
    
    public scr_Bounds bounds;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();


        CheckBounds();
    }

    private void Move()
    {
        var xInput = Input.GetAxisRaw("Horizontal");
        rb.AddForce(Vector2.right * xInput * horizontalForce);

        rb.velocity *= (1 - slowingFactor);
    }

    void CheckBounds()
    {
        if (transform.position.x < bounds.min)
        {
            transform.position = new Vector2(bounds.min, transform.position.y);
        }

        if (transform.position.x > bounds.max)
        {
            transform.position = new Vector2(bounds.max, transform.position.y);
        }
    }
}
