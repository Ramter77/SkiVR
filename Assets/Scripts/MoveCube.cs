using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 2;
    private float timer;
    public float timeToDestroy = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        if (timer > timeToDestroy) {
            Destroy(gameObject);
            
            timer -= timeToDestroy;
        }

        timer += Time.deltaTime;
    }
}
