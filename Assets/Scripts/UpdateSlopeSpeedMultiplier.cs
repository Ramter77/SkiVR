using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class UpdateSlopeSpeedMultiplier : MonoBehaviour
{
    public void _UpdateSlopeSpeedMultiplier() {
        float newSpeedMultiplier = GetComponent<PinchSlider>().SliderValue;
        SlopeController.Instance.UpdateSlopeSpeedMultiplier(newSpeedMultiplier);
    }
}
