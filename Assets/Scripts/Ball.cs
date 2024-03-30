using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //это логика каждого отдельно взятого шара
    [SerializeField] public int hitToCollision = 10;
    float speed = 20f;
    public Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //пока не удалять- надо проверить потом как работает с нормальной текстурой снаряда
        //если будут поворачиваться нормально, то можно удалять

        //Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rotateZ - 90);

        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitToCollision--;
        if (hitToCollision == 0)
            Destroy(gameObject);
    }
}
