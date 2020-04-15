using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class UpdateSlopeAngleMultiplier : MonoBehaviour
{
    public void _UpdateSlopeAngleMultiplier() {
        float newAngleMultiplier = GetComponent<PinchSlider>().SliderValue;
        SlopeController.Instance.UpdateSlopeAngleMultiplier(newAngleMultiplier);
    }
}
