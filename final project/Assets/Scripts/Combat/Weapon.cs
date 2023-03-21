using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;
    Animator animator;
    bool shooting;
    float frames;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shooting == true)
            frames++;
            
        if (Input.GetButtonDown("Fire1")) 
        {
            shooting = true;
            animator.SetTrigger("isShooting");
            Shoot();
        }
        
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
