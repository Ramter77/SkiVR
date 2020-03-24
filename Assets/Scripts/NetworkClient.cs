using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

namespace Project.Networking {
    public class NetworkClient : SocketIOComponent
    {
        // Start is called before the first frame update
        public override void Start()
        {
            base.Start();

            SetupAllEvents();
        }

        // Update is called once per frame
        public override  void Update()
        {
            base.Update();


        }

        private void SetupAllEvents() {
            On("open", (E) => {
                Debug.Log("Connection made to the server");
            });

            On("register", (E) => {
                Debug.Log("Registered to the server");
            });

            On("start", (E) => {
                Debug.Log("Start");
            });
        }
    }
}

