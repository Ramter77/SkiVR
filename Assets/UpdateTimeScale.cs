using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class UpdateTimeScale : MonoBehaviour
{
    public void _UpdateTimeScale() {
        float newTimeScale = GetComponent<PinchSlider>().SliderValue;
        TimeManager.Instance.UpdateTimeScale(newTimeScale);
    }
}
