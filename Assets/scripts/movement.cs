using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{ 

  public Rigidbody rb;

  public Vector3 moveDirection;

  public float walkSpeed;



    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();   
    


    }
    
    // Update is called once per frame
    void Update()
    { 
        walk();
      PlayerRotate(); 
    }

    // allows the player to move on the x and y axis 
    void walk()
    { moveDirection.x = Input.GetAxisRaw("Horizontal");
      moveDirection.y = Input.GetAxisRaw("Vertical");
      
      rb.MovePosition(rb.position+moveDirection*walkSpeed*Time.deltaTime);


    }
     
    
    void PlayerRotate()
    {
    Vector3 LookDir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);  // this makes the user mouse rotate the box to the way they want it to face

    float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg; // this tells us how much its been times by for the angle we want

     transform.rotation = Quaternion.AngleAxis(angle-90f, Vector3.forward); // this makes the it rotate depends where the mouse is 


    }
    
    
 
   void sprint()
   {

     if(Input.GetKey(KeyCode.LeftShift))
     {
      
            walkSpeed = 5;

     }
    else
    {

     walkSpeed = 5; 

    }
   }


  }