using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using Project.Networking;

namespace Project.Networking {
    public class NetworkClient : SocketIOComponent
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();

            SetupAllEvents();

            //socket.Emit("register", new JSONObject(JsonUtility.ToJson("Hello from VR")));


            //socket.Emit("hello");
        }

        // Update is called once per frame
        public override void Update()
        {
            base.Update();
            
        }

        private void SetupAllEvents() {
            On("open", (E) => {
                Debug.Log("Connection made to the server");
            });

            On("registerGame", (E) => {
                Debug.Log("Registered to the server");

                NetworkIdentity ni = GetComponent<NetworkIdentity>();
                ni.SetSocketReference(this);
            });

            On("start", (E) => {
                Debug.Log("Start");

                //NetworkIdentity ni = GetComponent<NetworkIdentity>();
                //ni.GetSocket().Emit("hello");

                //socket.Emit("hello");
                //socket.Emit("hello2", new JSONObject(JsonUtility.ToJson("Hello from VR")));
            });

            On("event", (E) => {
                Debug.Log("Received greeting from app; answering now...");
                //socket.Emit("register", new JSONObject(JsonUtility.ToJson("Hello from VR")));
            });
        }
    }
}

