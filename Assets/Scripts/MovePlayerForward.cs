using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerForward : MonoBehaviour
{
    public CharacterController characterController;
    public Transform forwardDir;




    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Move() {
        characterController.Move(forwardDir.forward * 20 * Time.deltaTime);
    }
}
