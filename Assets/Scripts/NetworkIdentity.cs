using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using Project.Networking;

namespace Project.Networking {
    public class NetworkIdentity : MonoBehaviour
    {
        /* private SocketIOComponent socket; */

        private SocketIOComponent socket;

        // Start is called before the first frame update
        void Start()
        {
            /* StartCoroutine(ExampleCoroutine()); */
        }

        /* IEnumerator ExampleCoroutine() 
        {
            Debug.Log(socket);
            yield return new WaitForSeconds(2);
            Debug.Log("Done waiting 2 sec");
            Debug.Log(socket);

            //GetSocket().Emit("hello");
        } */

        // Update is called once per frame
        void Update()
        {
            
        }

        public void SetSocketReference(SocketIOComponent Socket) {
            socket = Socket;
            Debug.Log("---------------SOCKET-------------");
            Debug.Log(socket);

            socket.Emit("hello");
        }

        public SocketIOComponent GetSocket() {
            return socket;
        }
    }
}
