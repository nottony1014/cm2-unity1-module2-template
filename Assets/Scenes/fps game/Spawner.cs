using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    [SerializeField] int maxEnemyCount = 3;
    public GameObject enemy;
    int currentEnemies = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (currentEnemies < maxEnemyCount)
        {
            GameObject spawnedEnememy = Instantiate(enemy);
           
            spawnedEnememy.transform.position = new  Vector3(Random.Range(-30f, 30f), 1, Random.Range(-30f, 30));
            currentEnemies++;
        }
    }
}
