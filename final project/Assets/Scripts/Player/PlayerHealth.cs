using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] PlayerData pd;

    //easily increase max health (sets current health = max)
    void increaseMaxHealth(int num) 
    {
        pd.maxHealth += num;
        pd.currentHealth = pd.maxHealth;
    }

    void fullHeal()
    {
        pd.currentHealth = pd.maxHealth;
    }

    void incrementHealth()
    {
        pd.currentHealth++;
    }

    void decrementHealth()
    {
        pd.currentHealth--;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyProjectile" || other.tag == "Enemy")
        {
            decrementHealth();
            Debug.Log(pd.currentHealth);
            Destroy(other.gameObject);
        }
    }
}