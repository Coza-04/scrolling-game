using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //What's this for?
using UnityEngine.UI;

/* TASK: Fix the broken code
* Use the Unity API
* Remember colours indicate working code
* Answer all of the questions
* Good luck
*/
public class TDS_Health : MonoBehaviour
{
    public float playerHealth; //What's this?
    private float maxHealth;
    public Slider healthSlider;

    private int life;
    void Start() {
        this.maxHealth = this.playerHealth;
    }

    void Update()
    {
        if(playerHealth <= 0)//What's the condition here?
        {
           GameOver();
        }

        // this.healthSlider.value = playerHealth / maxHealth;
    }
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");//What does this do?
    }


}





