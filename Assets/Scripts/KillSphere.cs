using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSphere : MonoBehaviour
{
    public bool debug;
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        //if on purple layer
        if (other.gameObject.layer == 22) {
            if (debug) {
                Debug.Log("COLLIDED WITH A PURPLE SPHERE, DESTROYED: " + other.gameObject);
            }

            if (other.gameObject.tag == "Destroyable") {
                Destroy(other.gameObject);
            }
        }
        
        //if on yellow layer
        else if (other.gameObject.layer == 23) {
            if (debug) {
                Debug.Log("COLLIDED WITH A YELLOW SPHERE, DESTROYED: " + other.gameObject);
            }

            if (other.gameObject.tag == "Destroyable") {
                Destroy(other.gameObject);
            }
        }
    }
}
