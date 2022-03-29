using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public float maxHealth;
    public GameObject healthBarUI;
    public Slider slider; 
    
    
    
    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateHealth();

        if (health< maxHealth)
        {
          healthBarUI.SetActive(true);  
        }

        if(health<=0)
        
        {
         Destroy (gameObject);
        }
        
        if(health> maxHealth)
        {
        health = maxHealth;    
        }
         

        
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
}