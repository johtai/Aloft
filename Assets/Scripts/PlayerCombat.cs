using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public float AttackRange;
    public float AttackRate = 2f;
    public float NextAttackTime = 0;

    public LayerMask enemyLayers;
    public Transform AttackPoint;
    public int AttackValue = 40;
    public Animator animator;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= NextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                NextAttackTime = Time.time + 1f / AttackRate;
            }
        }
    }
    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(player.position, AttackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(AttackValue);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}

