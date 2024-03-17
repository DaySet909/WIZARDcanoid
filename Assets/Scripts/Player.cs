using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jump = 150f;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveJump = KeyCode.Space;
    private Rigidbody2D rb2d;
    public GameObject bullet;
    public GameObject [] brickArray;
    public int jumpCount = 0;
    public int jumpMax = 1;
    public int healthHero = 1;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var vel = rb2d.velocity;

        if (Input.GetKey(moveLeft)) vel.x = -speed;
        else if (Input.GetKey(moveRight)) vel.x = speed;
        else vel.x = 0;
        rb2d.velocity = vel;

        if (Input.GetKeyDown(moveJump) && jumpCount > 0)
        {
            rb2d.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            jumpCount--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Ground") && jumpCount < jumpMax)
            jumpCount++;

        if (collision.collider.CompareTag("Ball"))
            DeathOfPlayer();
    }

    void DeathOfPlayer ()
    {
        Instantiate(brickArray[Random.Range(0, brickArray.Length)],transform.position + new Vector3(),Quaternion.identity);
        //rb2d.AddForce(new Vector2(Random.Range(100f, 700f), Random.Range(100f, 200f)), ForceMode2D.Impulse);
    }
}
