using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float offset;
    public GameObject bullet;
    public Transform shotPoint;
    void Update()
    {
        Vector3 diffence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diffence.y, diffence.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,rotZ + offset);

        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
        }

        if (Input.GetMouseButtonDown(1))
        {

        }
    }
}
