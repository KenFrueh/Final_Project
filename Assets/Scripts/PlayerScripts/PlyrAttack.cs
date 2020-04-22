using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrAttack : MonoBehaviour
{
    //Attacking variables
    public float btwAttack;
    public float startAttack;
    public Transform AttackPos;
    public LayerMask EnemiesL;
    public float rangeOfAttack;
    public int damageDone;

    // Update is called once per frame
    void Update()
    {
        //Attacking
        if (btwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {//Hitting the enemy
                Debug.Log("I attack!");
                Collider2D[] enemies = Physics2D.OverlapCircleAll(AttackPos.position, rangeOfAttack, EnemiesL);
                for (int i = 0; i < enemies.Length; i++)
                {
                    Destroy(enemies[i].gameObject);
                }
                btwAttack = startAttack;

            }
            else
            {
                btwAttack -= Time.deltaTime;
            }
        }
    }
    void OnDrawGizmosSelected()//Drawing a circle as point of reference of attack area
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPos.position, rangeOfAttack);//Changing radius of circle
    }
}
