using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    [SerializeField] public float player_speed = 10f;
    [SerializeField] public float player_jump = 150f;
    public int player_jumpMax = 1;
    public int player_healthHero = 1;
    [SerializeField] public int player_death = 0;
    int player_jumpCount = 0;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
