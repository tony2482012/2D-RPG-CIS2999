using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Selena

public class MainMenu : MonoBehaviour {

    public string mainScene;
    //public string levelSelect;
    //public string whatever;
    //public GameObject mainMenuCanvas;
    //public bool isStart;
    //public bool isQuit;

    public GameObject mainMenuCanvas;
    //public GameObject camera;
    //public GameObject pauseMenuCanvas;
    //public bool isPaused;
    //public string mainMenu;


	// Use this for initialization
	public void NewGame () {
        
        mainMenuCanvas.SetActive(false);
        //camera.SetActive(true);
        SceneManager.LoadScene("Main");


        //Debug.Log("Click");
		
	}

    public void LoadGame() {

        //Debug.Log("Click");
        //SceneManager.LoadScene(whatever);
        
    }

    //// Update is called once per frame
    //public void Quit () {

    //       Debug.Log("Game Exited");
    //       //Application.Quit();

    //       //SceneManager.LoadScene(Menu);



    //}
}
