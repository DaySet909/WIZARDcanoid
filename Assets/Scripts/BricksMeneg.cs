using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksMeneg : MonoBehaviour
{
    public GameObject brick;
    public int countOfBrickX = 3;
    public int countOfBrickY = 3;
    float scaleX;
    float scaleY;
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = brick.GetComponent<SpriteRenderer>();
        scaleX = spriteRenderer.bounds.size.x;
        scaleY = spriteRenderer.bounds.size.y;
        for (int i = 0; i < countOfBrickX; i++)
        {
            for (int j = 0; j < countOfBrickY; j++)
            {
                Instantiate(brick, transform.position + ( new Vector3(i * scaleX, j * -scaleY, 0)), Quaternion.identity);
            }

        }
    }

    void Update()
    {
        
    }
}
