using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    

    //variables for L/R movements
    public float runSpeed;
    float horizontalMove = 0f;
    bool playerFacingRight = true;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        if (horizontalMove > 0 && playerFacingRight)
        {
            Move();
        }
        else if (horizontalMove > 0 && !playerFacingRight)
        {
            Flip();
        }
        else if (horizontalMove < 0 && !playerFacingRight)
        {
            Move();
        }
        else if (horizontalMove < 0 && playerFacingRight)
        {
            Flip();
        }
    }

    void Move()
    {
        rb.AddForce(new Vector2((horizontalMove * runSpeed * Time.deltaTime), 0f), ForceMode2D.Impulse);
    }

    void Flip()
    {
        playerFacingRight= !playerFacingRight;

        transform.Rotate (0f, 180f, 0f);
    }
}