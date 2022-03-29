using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* TASK: Find the errors in this code
    *Use google if you need to, but i'd use the unity console
* TASK: Comment on each line of code
*/
public class TDS_Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed; // speed of the bullet 

    int isRight = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //
        rb.AddForce(transform.right * bulletSpeed * isRight, ForceMode.Impulse); // its times the force by the force 

        Destroy(gameObject, 1f); // the damage of each bullet when it hits it
    }


    // Set move direction (called by shoot script)
    public void IsRight(bool movingRight)
    {
        if (movingRight)
            isRight = 1;
        else
            isRight = -1;
    }
}
