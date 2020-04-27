using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCube : MonoBehaviour
{
    public bool debug;
    public int range = 2;
    public bool requireAngle;
    public int cutAngle = 130;
    public LayerMask layer;
    public float directionMultiplier = -1;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up*directionMultiplier, out hit, range, layer)) {
            
            //if is destroyable
            if (hit.transform.gameObject.tag == "Destroyable") {
                if (requireAngle) {
                    if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > cutAngle) {
                        Destroy(hit.transform.gameObject); 
                    }
                }
                else {
                    Destroy(hit.transform.gameObject);
                }

                if (debug) {
                    Debug.DrawRay(transform.position, transform.forward*directionMultiplier, Color.green);
                    Debug.Log("Destroyed by Raycast: " + hit.transform.gameObject.name);
                }
            }
        }

        previousPos = transform.position;
    }
}
