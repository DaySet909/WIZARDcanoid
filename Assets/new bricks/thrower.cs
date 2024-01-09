using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrower : MonoBehaviour
{
    public GameObject[] brick;



    void Start()
    {
    }

    void Update()
    {
        var brick = GameObject.FindWithTag("brickMassive");
        Vector3 vector3 = new Vector3.;
        Instantiate(brick, vector3, Quaternion.identity );

    }
}
