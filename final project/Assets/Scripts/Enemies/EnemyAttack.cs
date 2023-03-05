using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;
    public float delay = 2f;
    float timer;
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        timer += Time.deltaTime;

        if (distance < 5 && timer > delay)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    }
}
