using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public void _Duplicate() {
        Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
    }
}
