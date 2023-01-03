using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ChangerScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
