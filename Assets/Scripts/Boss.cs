using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//Removing health from enemy
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)//Enemy recieving damage
    {
        health -= damage;
        Debug.Log("Takes damage");
    }
    public void OnDestroy()
    {
        GameManager.instance.Victory();
    }
}
