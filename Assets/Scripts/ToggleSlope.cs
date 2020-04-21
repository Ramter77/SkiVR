using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSlope : MonoBehaviour
{
    public Material defaultMat;
    public Material slopeMat;

    public bool toggleBool;


    private MeshRenderer meshRenderer;

    public void _ToggleSlope() {
        if (toggleBool) {
            meshRenderer.material = slopeMat;
        }
        else {
            meshRenderer.material = defaultMat;
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
