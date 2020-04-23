using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrAttack : MonoBehaviour
{
    //Attacking variables
    private float btwAttack;
    public float startAttack;
    public Transform AttackPos;
    public LayerMask EnemiesL;
    public float rangeOfAttack;
    public int damageDone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {//Hitting the enemy
            Attack();
        }
    }
    public void Attack()
    {
        Debug.Log("I attack!");
        Collider2D[] enemies = Physics2D.OverlapCircleAll(AttackPos.position, rangeOfAttack, EnemiesL);
        foreach (Collider2D enemy in enemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(damageDone);
        }

    }
    void OnDrawGizmosSelected()//Drawing a circle as point of reference of attack area
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPos.position, rangeOfAttack);//Changing radius of circle
    }
}
