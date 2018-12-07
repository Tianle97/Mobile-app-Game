using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

namespace Scene
{
    public class MainMenuSceneController : MonoBehaviour
    {
        // == OnClick event ==
        public void PlayOnClick()
        {
            PauseMenu.GameIsPause = false;
            SceneManager.LoadSceneAsync(SceneNames.FIGHT);
        }

        public void QuitOnClick()
        {
            PauseMenu.GameIsPause = false;
            //Debug.Log("Quit Game...");
            Application.Quit();
            Debug.Log(PauseMenu.GameIsPause);
        }
    }
}
