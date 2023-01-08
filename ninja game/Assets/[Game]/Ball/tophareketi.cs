using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketi : MonoBehaviour
{
    // topSpeed de�i�keni, top objesinin hareket h�z�n� tutacak
    float topSpeed = 10.0f;
    // hareketY�n� de�i�keni, top objesinin hareket y�n�n� tutacak (sa�a veya sola)
    int hareketY�n� = 1;

    void Start()
    {
        // top objesinin ba�lang�� pozisyonunu ayarla
        transform.position = new Vector2(-7.0f, transform.position.y);
    }

    void Update()
    {
        // top objesinin x ekseninde hareketi
        transform.position += Vector3.right * topSpeed * Time.deltaTime * hareketY�n�;
        transform.position += Vector3.left* topSpeed * Time.deltaTime * hareketY�n�;

        // top objesi ekran�n d���na ��kt�ysa hareket y�n�n� de�i�tir
       /* if (Time.time > 4 && transform.position.x > 7.0f || transform.position.x < -7.0f)
        {
            Destroy(gameObject);
            Instantiate(gameObject);
        }*/
    }
}