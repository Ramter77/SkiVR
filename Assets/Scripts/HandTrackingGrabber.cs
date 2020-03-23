using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandTrackingGrabber : DistanceGrabber
{
    private OVRHand hand;
    [Range (0, 1)]
    public float pinchThreshold = 0.7f;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        hand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckPinch();
    }

    public void CheckPinch() {
        //Whole hand pinch strength
        //float pinchStrengthThumb = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Thumb);
        float pinchStrengthIndex = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        //float pinchStrengthMiddle = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Middle);
        /*float pinchStrengthRing = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Ring);
        float pinchStrengthPinky = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Pinky); */

        //Check for a fist
        bool isPinching;
        if (/* pinchStrengthThumb > pinchThreshold &&  */pinchStrengthIndex > pinchThreshold/*  && pinchStrengthMiddle > pinchThreshold */){/*  && pinchStrengthRing > pinchThreshold && pinchStrengthPinky > pinchThreshold) { */
            isPinching = true;
        }
        else
        {
            isPinching = false;
        }


        /* float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchThreshold; */

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0) {
            

            GrabBegin();
            //Debug.Log(m_grabbedObj);
            //if (m_grabbedObj.GetComponent<Collider>()) {m_grabbedObj.GetComponent<Collider>().isTrigger = true;}
            //if (m_grabbedObj.GetComponent<Rigidbody>()) {m_grabbedObj.GetComponent<Rigidbody>().useGravity = false;}
        }
        else if (m_grabbedObj && !isPinching) {
            GrabEnd();
        }
    }

    public void ForceGrabEnd() {
        GrabEnd();
    }

    protected override void GrabEnd() {

        if (m_grabbedObj) {
            //if (m_grabbedObj.GetComponent<Collider>()) {m_grabbedObj.GetComponent<Collider>().isTrigger = false;}
            //if (m_grabbedObj.GetComponent<Rigidbody>()) {m_grabbedObj.GetComponent<Rigidbody>().useGravity = true;}


            Vector3 linearVelocity = (transform.position - m_lastPos) / Time.fixedDeltaTime;
            Vector3 angularVelocity = (transform.eulerAngles - m_lastRot.eulerAngles / Time.fixedDeltaTime);

            GrabbableRelease(linearVelocity, angularVelocity); //takes care of collisions
            //GrabbableRelease(Vector3.zero, Vector3.zero);
            
        }
        
        GrabVolumeEnable(true);
    }
}
