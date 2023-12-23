using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffPosition : MonoBehaviour
{
    public Player player;
    [SerializeField] float x;
    [SerializeField] float y;
    void Update()
    {
        var p = player.transform.position;
        transform.position = new Vector2(p.x + 0.04f, p.y + 0.3f);
    }
}
