using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableJump : MonoBehaviour
{
    Rigidbody2D rb;
    public LayerMask groundLayer;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5.0f;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics2D.gravity.y * rb.gravityScale));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
        }
        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }
            if (jumpTime > buttonTime)
            {
                jumping = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if(jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }
    }

    bool IsGrounded() 
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        Debug.DrawRay(position, direction, Color.green);
        
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);

        //pretty sure i can do this without if statement but leaving it in for testing first
        if (hit.collider != null) {
            return true;
        }
        
        return false;
    }
}

//credit: https://gamedevbeginner.com/how-to-jump-in-unity-with-or-without-physics/#jump_unity