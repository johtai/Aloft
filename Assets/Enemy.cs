using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health;
    int maxHealth = 100;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        animator.SetTrigger("Hurt");

        if (health <= 0)
        {
            animator.SetTrigger("Death");
            this.enabled = false;
        }
    }
}
