using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TASK: Fix the broken code
* Use the Unity API
* Remember colours indicate working code
* Answer all of the questions
* Good luck
*/

public class TDS_Enemy : MonoBehaviour
{
    public GameObject playerTarget; //what is this?
    public float enemyMinDistance; //What is this for?
    public float damageAmount; //What does this do?
    public float attackDelay; //What's this for?
    public float attackRate; //What's this do? 
    float enemySpeed = 10f; //What's this for?

    void Start()
    {
        playerTarget = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        float disctance = Vector3.Distance(playerTarget.transform.position, transform.position); //What does this work out?
        if(disctance >= enemyMinDistance) //What is the condition here?
        {
            float step = enemySpeed * Time.deltaTime; //What is this for? What is Time.deltaTime?
            transform.position = Vector3.MoveTowards(transform.position, playerTarget.transform.position, step); //What does this do?
          Vector3 dir = playerTarget.transform.position - transform.position;
          float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
          transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //What's this for?
        }
        if(disctance <= enemyMinDistance) //what is the condition here?
        {
            if(Time.time > attackDelay) //what is the condition here?
            {
               EnemyAttack(); //What does this function do?
            }
        }
    }

    void EnemyAttack()
    {

       Debug.Log("Attacked"); //Why is this here?
        playerTarget.GetComponent<TDS_Health>().playerHealth -= damageAmount; //How does this work?
        attackDelay = Time.time + attackRate; //What does this do?
    } 
}
