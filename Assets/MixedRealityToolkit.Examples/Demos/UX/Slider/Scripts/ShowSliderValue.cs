//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/ShowSliderValue")]
    public class ShowSliderValue : MonoBehaviour
    {
        [SerializeField]
        private bool showSlopeAngleInstead;


        [SerializeField]
        private TextMeshPro textMesh = null;

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (textMesh == null)
            {
                textMesh = GetComponent<TextMeshPro>();
            }

            if (textMesh != null)
            {
                if (showSlopeAngleInstead) {
                    textMesh.text = (Mathf.Round(eventData.NewValue * 45f * 10f) / 10f).ToString() + "°";
                }
                else {
                    textMesh.text = $"{eventData.NewValue:F2}";
                }
            }
        }
    }
}
