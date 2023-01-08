using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour
{

    // timer değişkeni, her bir kürenin doğuş süresini tutacak
    float timer = 0f;

    // kureObject değişkeni, doğurulacak olan küre objesini tutacak
    public GameObject Balls;

    // doğuş aralığı (milisaniye cinsinden)
    int dokusAraliği = 3000;

    void Start()
    {
        timer = 0f;
        Balls = gameObject;
    }
    void Update()
    {
        timer += Time.deltaTime;

        // timer değişkeni doğuş aralığına ulaştıysa, top objesi doğur ve timer değişkenini sıfırla
        if (timer >= dokusAraliği)
        {
            // Öncelikle, topun sağdan, soldan veya her iki yönden instantiate edilebileceği pozisyonları belirlemelisiniz.
            Vector2 topInstantiatePositionRight = new Vector2(transform.position.x + 1.0f, transform.position.y);
            Vector2 topInstantiatePositionLeft = new Vector2(transform.position.x - 1.0f, transform.position.y);
           // Vector2 topInstantiatePositionBoth = new Vector2(transform.position.x, transform.position.y);

            // Rastgele sayı üretebilmek için System.Random sınıfını kullanabilirsiniz.
            System.Random random = new System.Random();
            int randomNumber = random.Next(1, 4); // Bu kod, 1 ile 3 arasında rastgele bir sayı üretir.

            // Rastgele sayıya göre topun hangi pozisyondan instantiate edileceğini belirleyin.
            if (randomNumber == 1)
            {
                Instantiate(Balls, topInstantiatePositionRight, Quaternion.identity);
            }
            if (randomNumber == 2)
            {
                Instantiate(Balls, topInstantiatePositionLeft, Quaternion.identity);
            }
           /* else if (randomNumber == 3)
            {
                Instantiate(Balls, topInstantiatePositionBoth, Quaternion.identity);
            }*/

            timer = 0;
        }

    }
}
