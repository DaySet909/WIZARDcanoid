using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 3;
    public int id = 0;
    public int multieplue = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
        hp--;
        HitBrick();
        }
    }

    void HitBrick ()
    {
        if (hp <= 0)
            Destroy(gameObject);
    }

    private void Start()
    {
        HitBrick();
    }

}
