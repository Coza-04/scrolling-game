using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* TASK: Find the errors in this code
    *Use google if you need to, but i'd use the unity console
* TASK: Comment on each line of code
*/
public class TDS_Shoot : MonoBehaviour
{
    public GameObject bulletPrefab; // the object that be shooting will be a bullet 
    public Transform firepoint; // the firepoint is where the bullet will come out off 
    

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // the button for the player to shoot 
        {
            GameObject bulletClone = Instantiate(bulletPrefab, firepoint); // everytime you shoot the bullet clones due to the spped and the amount that wants to come out 
            bulletClone.transform.parent = null; // each bullets keeps on cloning 
            bulletClone.GetComponent<TDS_Bullet>().IsRight(player.GetComponent<PlatformerController>().facingRight); // Make bullet fire in move direction
            
        }
    }
}





