﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAtStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }
}
