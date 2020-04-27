using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCube : MonoBehaviour
{
    public enum Hand
	{
		None      = OVRPlugin.Hand.None,
		HandLeft  = OVRPlugin.Hand.HandLeft,
		HandRight = OVRPlugin.Hand.HandRight,
	}

    [SerializeField]
	private Hand HandType = Hand.None;

    public bool debug;
    
    public int range = 2;
    public bool requireAngle;
    public int cutAngle = 130;
    public LayerMask layer;
    public float directionMultiplier = -1;
    private Vector3 previousPos;

    [Header("Haptics")]
    public bool enableVibration;
    public float vibrationFrequency = 1;
    public float vibrationAmplitude = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void DestroyGO(GameObject GO) {
        if (enableVibration) {
            if (HandType == Hand.HandLeft) {
                OVRInput.SetControllerVibration(vibrationFrequency, vibrationAmplitude, OVRInput.Controller.LTouch);
            }
            else if (HandType == Hand.HandRight) {
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
            }
        }
        
        Destroy(GO);
        if (debug) {Debug.Log("Destroyed by Raycast: " + GO.name);}
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up*directionMultiplier, out hit, range, layer)) {
            if (debug) {Debug.DrawRay(transform.position, transform.forward*directionMultiplier, Color.green);}
                    
            //if is destroyable
            if (hit.transform.gameObject.tag == "Destroyable") {
                if (requireAngle) {
                    if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > cutAngle) {
                        DestroyGO(hit.transform.gameObject); 
                    }
                }
                else {
                    DestroyGO(hit.transform.gameObject);
                }
            }
        }

        previousPos = transform.position;
    }
}
