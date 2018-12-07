using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

namespace Scene
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // == OnClick Event ==
        public void BackOnClick()
        {
            SceneManager.UnloadSceneAsync(SceneNames.STRAT);
        }
    }

}
