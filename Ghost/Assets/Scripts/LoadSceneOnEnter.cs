using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnEnter : MonoBehaviour {

    public string SceneNameToLoad;

	// Update is called once per frame
	void Update () {
         if (Input.GetKeyDown(KeyCode.Return))
        {
          if(SceneNameToLoad != "")
        {
          SceneManager.LoadScene(SceneNameToLoad);
        }
          }
   
    }
}
