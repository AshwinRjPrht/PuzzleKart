using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LoadSceneB");
    }

    public void LoadB(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }
    void play()
    {

    }
}