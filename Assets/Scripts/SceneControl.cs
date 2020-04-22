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

    private void Start() {
        //Remove this after testing
        //SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

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

        else if (Input.GetKey(KeyCode.A)) 
        {
            Scene[] scenes = SceneManager.GetAllScenes();

            foreach (Scene sc in scenes)
                Debug.Log("'" + sc.name + "'");
        }
    }
    #endregion

    IEnumerator LoadNewScene(int index)
    {
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
        yield return null;  // wait on frame & let unity update the active scene
        //NewSceneLoaded();
    }

    #region Load Scene
    public void LoadScene(int index) {
        //Start coroutine to load new scene and then wait a frame to set new active scene
        /* if (index != 0) {
            //Unload current active additive scene (always the second one?)
            SceneManager.UnloadSceneAsync(index);
            StartCoroutine(LoadNewScene(index));
        }
        else {
            Debug.Log("index was 0!");
        }  */





        /* if (index != 0) {
            //if (SceneManager.Get())
            SceneManager.UnloadSceneAsync(index);
            SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(index));
        }
        else {
            Debug.Log("index was 0!");
        } */
        Scene[] scenes = SceneManager.GetAllScenes();
        //Debug.Log("This many scenes: " + scenes.Length + " + and index: " + index);

        //Unload the second scene
        if (scenes.Length > 1) {
            SceneManager.UnloadSceneAsync(scenes[1], UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        }

        //Debug.Log("trying to load scene " + index);
        //Load and add the next scene
        SceneManager.LoadSceneAsync(index, LoadSceneMode.Additive);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(index));

        //SlopeController.Instance.FindSlope();
    }
    #endregion

    #region Reset Scene
    public void ResetScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("ACTIVE SCENE: " + SceneManager.GetActiveScene());
    }
    #endregion
}
