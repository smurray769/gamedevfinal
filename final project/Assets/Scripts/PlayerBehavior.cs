using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rb2d;
    [Header("Movement")]
    public float speed = 3f;
    public float forceMultiplier = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //standard rigidbody2d movement method
        rb2d.MovePosition(transform.position + (new Vector3(Input.GetAxisRaw("Horizontal"),0) * Time.fixedDeltaTime * speed));

        //====floaty astronaut method, be sure to mess with rigidbody2d's drag value in inspector!
        //rb2d.AddForce(new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * forceMultiplier * Time.fixedDeltaTime);
    }
}
