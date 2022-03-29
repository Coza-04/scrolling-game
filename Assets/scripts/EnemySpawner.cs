using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class EnemySpawner : MonoBehaviour {
    public Transform enemyPrefab; 
    public float spawnSpeed = 8f;
    private float delay;

    void Awake() {
        this.delay = spawnSpeed;
    }

    void FixedUpdate()
    {
        if(this.delay > 0) {
            this.delay -= Time.deltaTime; 
            return;
        }

        this.delay = this.spawnSpeed;

        float x = Random.Range(-84f, -13.8f);
        float y = Random.Range(-14.9f, 33f);

        Instantiate(enemyPrefab, new Vector3(x, y, 0f), Quaternion.identity);
    
    
    }

}



