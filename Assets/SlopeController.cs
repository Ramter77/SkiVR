using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeController : Singleton<SlopeController>
{
    public Transform slope;
    public float slopeAngle = 15;
    public float slopeSpeed = 1;


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

    public void UpdateSlopeAngle(float newSlopeAngle) {
        Debug.Log("UPDATED ANGLE: " + newSlopeAngle);
        //just for now *= and +1
        slopeAngle *= newSlopeAngle + 1;
    }

    public void UpdateSlopeSpeed(float newSlopeSpeed) {
        slopeSpeed = newSlopeSpeed;
    }

    private void AdjustSlopeProperties()
    {
        //Rotate the slope platform
        slope.parent.transform.eulerAngles = new Vector3(slopeAngle, 0, 0);

        //Adjust the texture scroll speed
        scrollTexScript.scrollSpeedMultiplier = slopeSpeed;
    }
}
