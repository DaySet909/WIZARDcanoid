using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hp = 3;
    public int ID = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp--;
        if (hp <= 0)
            HitBrick();
    }

    void HitBrick ()
    {
        Destroy(gameObject);
    }

}
