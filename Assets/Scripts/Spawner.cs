using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public Transform spawnPoint;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if (!spawnPoint) {
            spawnPoint = gameObject.GetComponent<Transform>();
        }
    }

    public void Spawn(int index) {
        Instantiate(prefabs[index], spawnPoint.position, spawnPoint.rotation);
    }
}
