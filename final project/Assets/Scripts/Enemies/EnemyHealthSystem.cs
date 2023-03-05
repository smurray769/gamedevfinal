using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    [SerializeField] EnemyData enemydata;
    int maxHealth;
    int currentHealth;

    void Start()
    {
        maxHealth = enemydata.maxHealth;
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth < 1)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            currentHealth--;
            Destroy(other.gameObject);
        }
    }
}
