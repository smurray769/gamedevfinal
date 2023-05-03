using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text healthTxt;
    public Text enemiesTxt;
    private PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        healthTxt.text = "health: " + playerHealth.currentHealth.ToString() + "/" + playerHealth.maxHealth.ToString();
        
    }


}
