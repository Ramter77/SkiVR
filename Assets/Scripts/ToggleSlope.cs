using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSlope : MonoBehaviour
{
    public Material defaultMat;
    public Material slopeMat;

    public bool toggleBool;
    public GameObject FakeSlope;


    private MeshRenderer meshRenderer;

    public void _ToggleSlope() {
        if (toggleBool) {
            meshRenderer.material = slopeMat;

            meshRenderer.enabled = true;
            FakeSlope.SetActive(false);
        }
        else {
            //meshRenderer.material = defaultMat;

            meshRenderer.enabled = false;
            FakeSlope.SetActive(true);
        }

        toggleBool = !toggleBool;
    }

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
