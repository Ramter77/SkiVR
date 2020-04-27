using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Object Ref")]
    public Transform spawnPoint;
    public GameObject[] EnemyPrefabs;
    //public EnemySpawnCycle spawnCycle;
    public GameObject EnemyBoss;

    [Header("Spawnrate")]
    public bool enableSpawn = false;
    public int maxEnemies = 500;
    public float spawnrate = 0;
    private float fallbackSpawnrate = 0;
    public int amountOfEnemysToSpawn = 1;

    [Header("Spawn position")]
    public float MinX = 0;
    public float MaxX = 0;
    public float MinY = 0;
    public float MaxY = 0;


    public float MinZ = 0;
    public float MaxZ = 0;
    private int spawnedEnemies;
    

    void Start()
    {
        fallbackSpawnrate = spawnrate;
        //spawnCycle = FindObjectOfType<EnemySpawnCycle>();
    }

    void Update()
    {
        if(enableSpawn)
        {
            if (spawnedEnemies >= maxEnemies) {
                enableSpawn = false;
            }

            spawnTimer();
        }        
    }

    public void spawnEnemy()
    {
        for(int i = 0; i < amountOfEnemysToSpawn; i++)
        {
            Vector3 centerPos = spawnPoint.position;
            Vector3 pos = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            Vector3 spawnPos = centerPos - pos;
            int random = Random.Range(0, EnemyPrefabs.Length);
            Instantiate(EnemyPrefabs[random], spawnPos, spawnPoint.rotation);
            spawnedEnemies += 1;
        }
        
    }

    void spawnTimer()
    {
        spawnrate -= Time.deltaTime; 
        if(spawnrate <= 0 && enableSpawn)
        {
            spawnEnemy();
            spawnrate = fallbackSpawnrate;
        }
        if(spawnrate <= 0 && !enableSpawn)
        {
            spawnrate = fallbackSpawnrate;
        }
    }
    
}
