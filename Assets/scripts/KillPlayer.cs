using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    /*[SerializeField] Transform spawnPoint;

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
    }*/
    void OnCollisionEnter2D(Collision2D collision)
    {
      
        SceneManager.LoadScene(2);
        FindObjectOfType<AudioManager>().Play("CarCrash");
      
    }
}
