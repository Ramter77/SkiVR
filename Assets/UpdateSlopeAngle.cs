using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class UpdateSlopeAngle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void _UpdateSlopeAngle() {
        Debug.Log("TRIGGER THIS");
        float newAngle = GetComponent<PinchSlider>().SliderValue;
        SlopeController.Instance.UpdateSlopeAngle(newAngle);
    }
}
