using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketdestroy : MonoBehaviour
{
    // topSpeed deðiþkeni, top objesinin hareket hýzýný tutacak
    float topSpeed = 10.0f;

    // hareketYönü deðiþkeni, top objesinin hareket yönünü tutacak (saða veya sola)
    int hareketYönü = 1;

    // yokOlmaSüresi deðiþkeni, top objesinin yok olma süresini tutacak (saniye cinsinden)
    float yokOlmaSüresi = 5.0f;

    void Start()
    {
        // top objesinin baþlangýç pozisyonunu ayarla
        transform.position = new Vector2(-7.0f, transform.position.y);
    }

    void Update()
    {
        // top objesinin x ekseninde hareketi
        transform.position += Vector3.right * topSpeed * Time.deltaTime * hareketYönü;

        // top objesi ekranýn dýþýna çýktýysa yok olma süresini azalt
        if (transform.position.x > 7.0f || transform.position.x < -7.0f)
        {
            yokOlmaSüresi -= Time.deltaTime;
        }

        // yokOlmaSüresi 0'a ulaþtýysa top objesi yok et ve yeniden doður
        if (yokOlmaSüresi <= 0)
        {
            Destroy(gameObject);
            Instantiate(gameObject);
        }
    }
}
