using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed = 20f;
    private Rigidbody2D body;
    int hitToCollision = 0;
    public Rigidbody2D rb;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        rb = GetComponent<Rigidbody2D>();

        //пока не удалять- надо проверить потом как работает с нормальной текстурой
        //если будут поворачиваться нормально, то можно удалять

        //Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rotateZ - 90);

        rb.velocity = transform.up * speed;
}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitToCollision++;
        if (hitToCollision == 10)
            Destroy(gameObject);
    }
}
