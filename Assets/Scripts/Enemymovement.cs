using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{   
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float speed = 0.1f;


    void Start()
   {
       rb = this.GetComponent<Rigidbody2D>();     
   }

   void Update()
   {
       Vector3 direction = player.position - transform.position;
       float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       direction.Normalize();
       movement = direction;
   }

    void FixedUpdate()
   {
       MoveChar(movement);
   }

    void MoveChar(Vector2 direction)
   {
       rb.MovePosition((Vector2)transform.position + (direction * speed *  Time.deltaTime));
       
   }
}
