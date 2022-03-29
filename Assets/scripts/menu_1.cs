using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class menu_1 : MonoBehaviour

{



    public Button play;

    public Button quit;



    void Start()

    {

        play.onClick.AddListener(Play);

        quit.onClick.AddListener(Quit);

    }



    public void Play()

    {

        SceneManager.LoadScene("Game");



    }



    public void Quit()

    {

        Application.Quit();

    }

}