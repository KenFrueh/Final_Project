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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Attacking
        if (btwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Collider2D[] enemies = Physics2D.OverlapCircleAll(AttackPos.position, rangeOfAttack, EnemiesL);
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<Enemy>().TakeDamage(damageDone);
                }
                btwAttack = startAttack;
            }
            else
            {
                btwAttack -= Time.deltaTime;
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPos.position, rangeOfAttack);

    }
}
