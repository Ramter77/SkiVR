using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeatCubes : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;

    [Tooltip ("Beat = BPM/100*2")]
    public float beat = 60/100*2;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat) {
            GameObject cube = Instantiate(cubes[Random.Range(0, cubes.Length)], points[Random.Range(0, points.Length)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(Vector3.forward*-1, 90 * Random.Range(0, 4));

            timer -= beat;
            
        }

        timer += Time.deltaTime;
    }
}
