using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class Quit_Button : MonoBehaviour

{

    public Button quit;



    void Start()

    {

        quit.onClick.AddListener(Quit);

    }



    public void Quit()

    {

        Application.Quit();

    }

}