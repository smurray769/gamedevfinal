using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    int health = 100;

    void Start()
    {

    }

    void Update()
    {
        if (health < 1)
        {
            Debug.Log("goodbye cruel world");
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            health-=25;
            Debug.Log("Ow!");
            Destroy(other.gameObject);
        }
    }
}
