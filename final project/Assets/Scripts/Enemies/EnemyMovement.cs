using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Rigidbody2D rb;
    float runSpeed = 2f;
    Transform enemy;
    int dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        WalkInDirection(dir);
    }

    void WalkInDirection(int dir) 
    {
        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * dir * runSpeed,
                        enemy.position.y, enemy.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        dir = dir*-1;
    }

}