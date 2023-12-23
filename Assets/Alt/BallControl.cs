using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public static Rigidbody2D rb2d;
    private int hitTimeOut;
    private float hitTimeOutPositionX;
    private float hitTimeOutPositionY;

    void GoBall()
    {
    }
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        GoBall();
    }

    private void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        GoBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.collider.CompareTag("Player"))

    }
}
