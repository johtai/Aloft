using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    int health;
    int maxHealth = 100;
    public Animator animator;

    //For Movement---
    public Transform player;
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private Vector2 movement;
    private float speed = 0.1f;


    void Start()
    {
        health = maxHealth;
        rb = this.GetComponent<Rigidbody2D>();  //-
        bc = this.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        //--For Move---
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
        //-----------------
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        animator.SetTrigger("Hurt");

        if (health <= 0)
        {
            animator.SetTrigger("Death");
            this.enabled = false;
            bc.enabled = false;            //Отключение коллайдера после смерти
            Destroy(this.gameObject,5.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
    if(collision.gameObject.CompareTag("Bullet"))
    {
      TakeDamage(50);  
    }
  }


//For Movement
void FixedUpdate()
   {
       MoveChar(movement);
   }

    void MoveChar(Vector2 direction)
   {
       rb.MovePosition((Vector2)transform.position + (direction * speed *  Time.deltaTime));
       
   }
//-------------------
}