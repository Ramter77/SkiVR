using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMaterial : MonoBehaviour
{
    public Material mirrorMat;
    public Material screenMat;
    private Material previousMaterial;
    private MeshRenderer meshRenderer;

    public bool inMenu;
    public GameObject SelectionMenu;
    private ToggleGO ToggleGOScript;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        ToggleGOScript = GetComponent<ToggleGO>();
    }

    public bool toggleBool;

    public void _ToggleScreen() {   //on pressing the "select scene" button
        //Save previous material
        previousMaterial = meshRenderer.material;

        //Set screen material
        meshRenderer.material = screenMat;

        inMenu = true;
    }

    public void _ToggledMirrorButton() {
        if (inMenu) {
            /* if (GetComponent<Interactable>().IsToggled) {
                gameObject.SetActive
            } */

            _ToggleMirror();
            SelectionMenu.SetActive(false);
            ToggleGOScript._ToggleGO();
        }
        else
        {
            //Debug.Log("istoggled: " + GetComponent<Interactable>().IsToggled);

            ToggleGOScript._ToggleGO();
            //gameObject.SetActive(GetComponent<Interactable>().IsToggled);
        }




        /* if (GetComponent<Interactable>().IsToggled) {
            gameObject.SetActive(false);
            SelectionMenu.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        } */






        /* if (inMenu) {
            inMenu = false;

            gameObject.SetActive(false);
            SelectionMenu.SetActive(false);
        }
        else
        {
            gameObject.SetActive(GetComponent<Interactable>().IsToggled);
        } */
    }
    
    /* public void _ToggledMirrorButton() {
        //if mirror is active
        if (gameObject.activeSelf) {
            gameObject.SetActive(false);
        }
        else //if screen is active
        {
            
        }


        //if it was a mirror
        if (meshRenderer.material == mirrorMat) {

        }
        meshRenderer.material = previousMaterial;
    } */

    /* public void _ToggleReset() {    //on pressing a level button go back to previous material
        meshRenderer.material = previousMaterial;
    } */

    public void _ToggleMirror() {
        meshRenderer.material = mirrorMat;

        inMenu = false;
    }

/*     public void _ToggleMaterial() {
        //if previous material was not the current material then 
        if (previousMaterial != meshRenderer.material) {
            if (meshRenderer.material == mirrorMat) {
                meshRenderer.material = screenMat;
            }
            else {
                meshRenderer.material = mirrorMat;
            }
        }

        previousMaterial = meshRenderer.material;


        if (toggleBool) {
            meshRenderer.material = mirrorMat;
        }
        else {
            meshRenderer.material = screenMat;
        }

        toggleBool = !toggleBool;
        
    } */
}
