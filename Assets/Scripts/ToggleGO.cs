using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGO : MonoBehaviour
{
    public bool toggleBool;

    public void _ToggleGO() {
        gameObject.SetActive(toggleBool);
        toggleBool = !toggleBool;
    }
}
