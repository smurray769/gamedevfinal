using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //...setting shoot direction
        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = shootDirection-transform.position;

        //rb.velocity = transform.right * speed;
        rb.velocity = new Vector2(shootDirection.x * speed, shootDirection.y * speed);
        Destroy(this.gameObject, 5.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platforms")
        {
            Destroy(this.gameObject);
        }
    }

}
