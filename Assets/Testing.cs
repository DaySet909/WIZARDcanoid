using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public Player play;
    void Start()
    {
        
    }


    void Update()
    {
        var moving = play.death;
        transform.position = new Vector3( moving, 0);
    }
}
