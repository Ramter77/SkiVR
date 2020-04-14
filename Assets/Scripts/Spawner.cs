using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public Transform spawnPoint;
    public List<Transform> spawnPoints;
    private float timer;
    public float beat = 1;

    //public Transform spawnPoint;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if (spawnPoints.Count < 1) {
            //spawnPoints = gameObject.GetComponent<Transform>();
            spawnPoints.Add(gameObject.GetComponent<Transform>());
        }
    }

    private void Update() {
        if (timer > beat) {
            SpawnRandomly(1);
            
            timer -= beat;
        }

        timer += Time.deltaTime;
    }

    public void Spawn(int index) {
        Instantiate(prefabs[index], spawnPoint.position, spawnPoint.rotation);
    }

    public void SpawnRandomly(int index) {
        int rnd = Random.Range(0, spawnPoints.Count);
        Instantiate(prefabs[index], spawnPoints[rnd].position, spawnPoints[rnd].rotation);
    }
}
