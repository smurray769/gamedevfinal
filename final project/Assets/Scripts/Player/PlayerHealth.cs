using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth;

    //getters
    int getCurrentHealth() { return currentHealth; }
    int getMaxHealth() { return maxHealth; }
    
    //setters
    void setCurrentHealth(int num) { currentHealth = num; }
    void setMaxHealth(int num) { maxHealth = num; currentHealth = maxHealth; }

    //easily increase max health (sets current health = max)
    void increaseMaxHealth(int num) { maxHealth += num; currentHealth = maxHealth;}

    //quickly reset current health to max
    void fullHeal() { currentHealth = maxHealth; }

    void heal(int num)
    {
        if ( currentHealth + num < maxHealth)
        {
            currentHealth += num;
        }
        else
        {
            currentHealth = maxHealth;
        }
    }

    void damage(int num)
    {
        currentHealth-= num;
    }

}
