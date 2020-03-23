using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGrabbables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
