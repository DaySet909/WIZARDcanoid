using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffPosition : MonoBehaviour
{
    public Player player;
    [SerializeField] public float x = 0.04f;
    [SerializeField] public float y = 0.3f;
    void Update()
    {
        var p = player.transform.position;
        transform.position = new Vector3(p.x + x, p.y + y, 0);
    }
}
