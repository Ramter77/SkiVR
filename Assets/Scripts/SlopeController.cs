using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeController : Singleton<SlopeController>
{
    public Transform slope;

    [Header ("Angle")]
    public float slopeAngle = 15;
    public float slopeAngleMultiplier = 1;

    [Header ("Speed")]
    public float slopeSpeed = 1;
    public float slopeSpeedMultiplier = 1;


    private scrollTex scrollTexScript;



    // Start is called before the first frame update
    void Start()
    {
        if (!slope) {
            Debug.Log("No Slope found!");
        }


        scrollTexScript = slope.GetComponent<scrollTex>();
    }

    // Update is called once per frame
    void Update()
    {
        //Adjust slope speed & angle each frame
        AdjustSlopeProperties();
    }

    public void UpdateSlopeAngleMultiplier(float newSlopeAngleMultiplier) {
        Debug.Log("UPDATED ANGLE: " + newSlopeAngleMultiplier);
        slopeAngleMultiplier = newSlopeAngleMultiplier;
    }

    public void UpdateSlopeSpeedMultiplier(float newSlopeSpeedMultiplier) {
        slopeSpeedMultiplier = newSlopeSpeedMultiplier;
    }

    private void AdjustSlopeProperties()
    {
        //Rotate the slope platform
        slope.parent.transform.eulerAngles = new Vector3(slopeAngle * slopeAngleMultiplier, 0, 0);

        //Adjust the texture scroll speed
        scrollTexScript.scrollSpeedMultiplier = slopeSpeed * slopeSpeedMultiplier;
    }
}
