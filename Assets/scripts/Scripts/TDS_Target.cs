using UnityEngine;

public class TDS_Target : MonoBehaviour 
{
    [SerializeField] int health = 1;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.tag);
        if (other.CompareTag("Bullet"))
        {
            // Decrease health
            health--;
            
            // Destroy enemy if health is less than one
            if (health <= 0)
                Destroy(other.gameObject);

            // Destroy bullet
            Destroy(gameObject);
        }
    }
}









