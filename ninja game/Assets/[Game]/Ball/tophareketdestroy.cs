using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketdestroy : MonoBehaviour
{
    // topSpeed de�i�keni, top objesinin hareket h�z�n� tutacak
    float topSpeed = 10.0f;

    // hareketY�n� de�i�keni, top objesinin hareket y�n�n� tutacak (sa�a veya sola)
    int hareketY�n� = 1;

    // yokOlmaS�resi de�i�keni, top objesinin yok olma s�resini tutacak (saniye cinsinden)
    float yokOlmaS�resi = 5.0f;

    void Start()
    {
        // top objesinin ba�lang�� pozisyonunu ayarla
        transform.position = new Vector2(-7.0f, transform.position.y);
    }

    void Update()
    {
        // top objesinin x ekseninde hareketi
        transform.position += Vector3.right * topSpeed * Time.deltaTime * hareketY�n�;

        // top objesi ekran�n d���na ��kt�ysa yok olma s�resini azalt
        if (transform.position.x > 7.0f || transform.position.x < -7.0f)
        {
            yokOlmaS�resi -= Time.deltaTime;
        }

        // yokOlmaS�resi 0'a ula�t�ysa top objesi yok et ve yeniden do�ur
        if (yokOlmaS�resi <= 0)
        {
            Destroy(gameObject);
            Instantiate(gameObject);
        }
    }
}
