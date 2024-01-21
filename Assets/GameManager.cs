using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded =false;
    public float restartDelay =1f;
    public GameObject CompleteLevelUI;
    public void CompleteLevel ()
        {
             CompleteLevelUI.SetActive(true);
        }
    

 public void EndGame ()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GAME OVER"); //restart game
            Restart();
            Invoke("Restart",restartDelay);
        }
        
    }
    void Restart()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
