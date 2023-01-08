using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketi : MonoBehaviour
{
    // topSpeed deðiþkeni, top objesinin hareket hýzýný tutacak
    float topSpeed = 10.0f;
    // hareketYönü deðiþkeni, top objesinin hareket yönünü tutacak (saða veya sola)
    int hareketYönü = 1;

    void Start()
    {
        // top objesinin baþlangýç pozisyonunu ayarla
        transform.position = new Vector2(-7.0f, transform.position.y);
    }

    void Update()
    {
        // top objesinin x ekseninde hareketi
        transform.position += Vector3.right * topSpeed * Time.deltaTime * hareketYönü;
        transform.position += Vector3.left* topSpeed * Time.deltaTime * hareketYönü;

        // top objesi ekranýn dýþýna çýktýysa hareket yönünü deðiþtir
       /* if (Time.time > 4 && transform.position.x > 7.0f || transform.position.x < -7.0f)
        {
            Destroy(gameObject);
            Instantiate(gameObject);
        }*/
    }
}