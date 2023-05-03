using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 5;
    public int maxHealth = 5;

    void Start()
    {
        currentHealth = maxHealth;
    }

    //easily increase max health (sets current health = max)
    public void increaseMaxHealth(int num) 
    {
        maxHealth += num;
        currentHealth = maxHealth;
    }

    public void fullHeal()
    {
        currentHealth = maxHealth;
    }

    public void incrementHealth()
    {
        currentHealth++;
    }

    public void decrementHealth()
    {
        currentHealth--;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EnemyProjectile")
        {
            decrementHealth();
            Destroy(other.gameObject);
            checkForDead();
        }

        if (other.tag == "Enemy")
        {
            decrementHealth();
            checkForDead();
        }

        if (other.tag == "SmallHeart")
        {
            if (currentHealth < maxHealth)
                incrementHealth();
            Destroy(other.gameObject);
        }

        if (other.tag == "Door")
        {
            Debug.Log("touched the door");
            SceneManager.LoadScene("End");
        }
    }

    void checkForDead()
    {
        if (currentHealth <= 0)
            SceneManager.LoadScene("Dead");
    }

}