using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
   public float moveSpeed;
   private float maxSpeed = 3.5f;
//    public Vector3 spawn;

   private Vector3 input;

   void Start()
   {
    //    spawn = transform.position;
   }

   void Update()
   {
       input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
       if(GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
       {
       GetComponent<Rigidbody>().AddForce(input*moveSpeed);
       }
   }

//    void OnCollisionEnter(Collision other)
//    {
//        if(other.transform.tag == "Enemy")
//        {
//             Die();
//        }
//    }

//    void Die()
//    {
//        transform.position = spawn;
//    }
}
