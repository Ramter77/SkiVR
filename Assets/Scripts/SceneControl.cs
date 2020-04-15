using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : Singleton<SceneControl>
{
    #region Variables
    [Tooltip("HotKey to reset current scene; use number keys to load the corresponding scene")]
    [SerializeField]
    private KeyCode resetHotkey = KeyCode.P;
    #endregion

    void Update()
    {
        ResetSceneInput();

        LoadSceneByKey();
    }

    void ResetSceneInput() {
        if (Input.GetKey(resetHotkey)) 
        {
            ResetScene();
        }
    }

    #region LoadSceneByKey
    void LoadSceneByKey() {
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            LoadScene(1);
        }
        else if (Input.GetKey(KeyCode.Alpha2)) 
        {
            LoadScene(2);
        }
        else if (Input.GetKey(KeyCode.Alpha3)) 
        {
            LoadScene(3);
        }
        else if (Input.GetKey(KeyCode.Alpha4)) 
        {
            LoadScene(4);
        }
        else if (Input.GetKey(KeyCode.Alpha5)) 
        {
            LoadScene(5);
        }
        else if (Input.GetKey(KeyCode.Alpha6)) 
        {
            LoadScene(6);
        }
        else if (Input.GetKey(KeyCode.Alpha7)) 
        {
            LoadScene(7);
        }
        else if (Input.GetKey(KeyCode.Alpha8)) 
        {
            LoadScene(8);
        }
        else if (Input.GetKey(KeyCode.Alpha9)) 
        {
            LoadScene(9);
        }
    }
    #endregion

    #region Load Scene
    public void LoadScene(int index) {
        SceneManager.LoadScene(index);
    }
    #endregion

    #region Reset Scene
    public void ResetScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    #endregion
}
