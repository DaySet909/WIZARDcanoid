using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksMeneg : MonoBehaviour
{
    public GameObject[] bricksArray;
    public GameObject brick;
    private SpriteRenderer spriteRenderer;
    public int countOfBrickX = 3;
    public int countOfBrickY = 3;
    int[,] borick = new int[7, 58] 
    
    {   { 1,1,1,1,1,1,1,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,1,1,1,1,1,1,0,0,0,0,0,1,1,1,0,0,0,0},
        { 0,0,0,0,0,1,1,0,0,0,0,1,1,0,1,1,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,1,1,0,0,0,1,1,0,1,1,0,0,0},
        { 0,0,0,0,1,1,0,0,0,0,1,1,0,0,0,1,1,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,1,1,0,0,1,1,0,0,0,1,1,0,0},
        { 0,0,0,1,1,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,1,1,1,1,1,1,0,0,1,1,0,0,0,0,0,1,1,0},
        { 0,0,1,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0},
        { 0,1,1,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0},
        { 1,1,1,1,1,1,1,1,0,1,1,0,0,0,0,0,1,1,0,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,0,0,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,1,0} };


    float scaleX;
    float scaleY;

    void Start()
    {
        spriteRenderer = brick.GetComponent<SpriteRenderer>();
        scaleX = spriteRenderer.bounds.size.x;
        scaleY = spriteRenderer.bounds.size.y;

        for (int y = 0; y < borick.GetLength(1); y++)
        {
            for (int x = 0; x < borick.GetLength(0); x++)
            {
               // var brickRandom = bricksArray[Random.Range(0, bricksArray.Length)];
                //int brickRandom = borick[i,j];
                Instantiate(bricksArray[borick[x , y]], transform.position + ( new Vector3(y * scaleX, x * -scaleY, 0)), Quaternion.identity);
            }
        }
    }
}
