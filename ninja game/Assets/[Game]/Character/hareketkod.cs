using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketkod : MonoBehaviour
{
    float speed = 0.25f;
    float rodspeed = 80;
    float gravity = 8;


    private Animator animator;
    private bool isGrounded;

 void Start()
 {
     animator = GetComponent<Animator>();
 }


 void Update()
 {
     // E�er "Space" tu�una bas�ld�ysa, "Jump" parametresini tetikleyin
     if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
     {
         animator.SetTrigger("jump");
     }
     // E�er "A" veya "D" tu�una bas�ld�ysa, "Run" parametresini tetikleyin
     if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
     {
         animator.SetTrigger("run");
     }
     // Hi�bir tu�a bas�lmad�ysa, "Idle" parametresini tetikleyin
     if (Input.anyKey)
     {
         // E�er herhangi bir tu�a bas�lm��sa, hi�bir �ey yapma
     }
     else
     {
         // E�er hi�bir tu�a bas�lmam��sa, idle animasyonunu �al��t�r
         animator.SetTrigger("idle");
     }
 }
}

// float speed = 0.25f;
// float rodspeed = 80;
/* float gravity = 8;
 float rotation = 0;

 Vector3 moveDirector = Vector3.zero;
 CharacterController kontrol;
 Animator anim;
 void Start()
 {
     kontrol = GetComponent<CharacterController>();
     anim = GetComponent<Animator>();
 }

 // Update is called once per frame
 void Update()
 {
     if (kontrol.isGrounded)
     {
         if (Input.GetKey(KeyCode.Space))
         {
             moveDirector = new Vector3(0, 0, 1);
          //   moveDirector *= speed;
             anim.SetInteger("hareketdegerleri", 1);
             moveDirector = transform.TransformDirection(moveDirector);
         }
         else { 
             moveDirector = new Vector3(0, 0, 0);
             anim.SetInteger("hareketdegerleri", 0);
         }
     }
 }

 */

