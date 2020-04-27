using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("----------------------------------------------colllll--------------------------------------------------------Collided with: " + other.gameObject);
        if (other.gameObject.tag == "Destroyable") {
            Debug.Log("Destroyed");
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("------------------------------------------------------------------------------------------------------Collided with: " + other);
        if (other.tag == "Destroyable") {
            Debug.Log("Destroyed");
            Destroy(other.gameObject);
        }
    }
}
