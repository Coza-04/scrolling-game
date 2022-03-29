using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//STARTER TASK
//Fix this code
//Comment each line explaining what it does

public class StartMenu : MonoBehaviour
{
    public bool GameIsPaused = false; //what's this for
    public GameObject PauseMenu; //what's this for?
    void start()
    {
        Time.timeScale = 0f; //what's this for, why is it important?
        GameIsPaused = true; 
    }

    public void PlayGame()
    {
        GameIsPaused = false;
        Time.timeScale = 1f; //what does this do?
        PauseMenu.SetActive(false); //what is this for?
    
    }
}



