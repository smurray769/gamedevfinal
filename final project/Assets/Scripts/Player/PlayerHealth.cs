using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] PlayerData pd;
    int currentHealth = 5;

    void Start()
    {
        currentHealth = pd.maxHealth;
    }

    //easily increase max health (sets current health = max)
    void increaseMaxHealth(int num) 
    {
        pd.maxHealth += num;
        pd.currentHealth = pd.maxHealth;
    }

    void fullHeal()
    {
        currentHealth = pd.maxHealth;
    }

    void incrementHealth()
    {
        currentHealth++;
    }

    void decrementHealth()
    {
        currentHealth--;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyProjectile" || other.tag == "Enemy")
        {
            decrementHealth();
            Debug.Log(currentHealth);
            Destroy(other.gameObject);
        }
    }
}