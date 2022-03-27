using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenuUI;
    bool isPaused = false;
    
    public void pauseGame()
    {
        if(isPaused)
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
            Debug.Log(" Paused");
        }
        else
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
            Debug.Log("Is Paused1");
        }
    }
}
