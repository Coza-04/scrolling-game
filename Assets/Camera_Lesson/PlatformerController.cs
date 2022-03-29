using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerController : MonoBehaviour
{
    public float walkSpeed;
    public float jumpHeight;
    public float gravity = 0f;
    public bool facingRight = true; // Must be public for Bullets to fire in move direction
    CharacterController controller;
    public Animator animator;    
    Vector3 velocity;
    Vector3 moveDirection;

    bool grounded;

    public Transform groundChecker;
    public LayerMask groundLayers;

    void Start()
    {
        controller = GetComponent<CharacterController>();  
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("space pressed");
            Jump();
        }
        Walking(); 
    }

    void Walking()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.up);
        controller.Move(moveDirection * walkSpeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
          
        animator.SetFloat("speed", Mathf.Abs(moveHorizontal));

        if(moveHorizontal > 0 && !facingRight)
        {
            Flip();
        }
        else if(moveHorizontal < 0 && facingRight)
        {
            Flip();
        }
        
        
    }
    
    void Jump()
    {
        // if (IsGrounded())
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }
    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(groundChecker.position, 0.5f, groundLayers);

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }
}
