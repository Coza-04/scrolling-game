using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDS_Movement : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 moveDirection;
    public float walkSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        PlayerRotate();
        Walk();
    }
    
    void Walk()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
        
        rb.MovePosition(rb.position + moveDirection * (walkSpeed * 100) * Time.deltaTime);

        
    }

    void PlayerRotate()
    {
        Vector3 lookDir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
        
    }
}
