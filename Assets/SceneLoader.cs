using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void onStartClick()
    {
        Debug.Log("Scene loading");
    }

    public void onExitClick()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
