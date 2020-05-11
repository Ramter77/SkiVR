using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;

public class ShowSlopeAngle : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro textMesh = null;

    private float _slopeAngle;

    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (textMesh == null)
        {
            textMesh = GetComponent<TextMeshPro>();
        }

        if (textMesh != null)
        {
            textMesh.text = SlopeController.Instance.slopeAngle.ToString();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
