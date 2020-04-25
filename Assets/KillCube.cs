using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCube : MonoBehaviour
{
    public LayerMask layer;
    public float directionMultiplier = 1;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward*directionMultiplier, out hit, 2, layer)) {
            Debug.DrawRay(transform.position, transform.forward*directionMultiplier, Color.green);

            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130) {
                Destroy(hit.transform.root.gameObject);
                Debug.Log("DESTRYOOYDEDED  BY YYVYVYVYYVY RAAAAAAAAAYCAAAAAAAAAAST " + hit.transform.root.gameObject.name);
            }
        }

        previousPos = transform.position;
    }
}
