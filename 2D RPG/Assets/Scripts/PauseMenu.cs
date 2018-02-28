using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Selena

public class PauseMenu : MonoBehaviour {

    public string mainMenu;
    public bool isMainMenu;
    public bool isPaused;
    public GameObject pauseMenuCanvas;
    public GameObject mainMenuCanvas;
    public GameObject NewGameButton;
    public GameObject SaveGameButton;
    public GameObject ResumeButton;
    public GameObject LoadButton;
    public GameObject QuitButton;

	// Update is called once per frame
	void Update () {
		
        if (isMainMenu) {
            mainMenuCanvas.SetActive(true);
            //SaveGameButton.SetActive(false);
            //ResumeButton.SetActive(false);
            //QuitButton.SetActive(false);
            //NewGameButton.SetActive(true);
            //LoadButton.SetActive(true);
            Time.timeScale = 0f;

        } else {
            //mainMenuCanvas.SetActive(false);
            //SaveGameButton.SetActive(true);
            //ResumeButton.SetActive(true);
            //QuitButton.SetActive(true);
            //NewGameButton.SetActive(false);
            //LoadButton.SetActive(false);
            Time.timeScale = 1f;
        }

        if (isPaused) {
            pauseMenuCanvas.SetActive(true);
            //SaveGameButton.SetActive(true);
            //ResumeButton.SetActive(true);
            //QuitButton.SetActive(true);
            //NewGameButton.SetActive(false);
            //LoadButton.SetActive(false);
            Time.timeScale = 0f;
        } else {
            pauseMenuCanvas.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) | Input.GetKeyDown(KeyCode.P)) {
            isPaused = true;

        }

	}

    public void Resume () {

        isPaused = false;
        
    }

    public void Save() {

    
        
    }

    public void ButtonNewGame() {

        isMainMenu = false;
        SceneManager.LoadScene("CombatTestScene");

    }

    public void Quit() {



        //mainMenuCanvas.SetActive(true);
        //SaveGameButton.SetActive(false);
        //ResumeButton.SetActive(false);
        //QuitButton.SetActive(false);
        //NewGameButton.SetActive(true);
        //LoadButton.SetActive(true);
        //Time.timeScale = 1f;
        isMainMenu = true;
        SceneManager.LoadScene("CombatTestScene");
        //SceneManager.SetActiveScene("TitleMenu");
        //isMainMenu = true;

    }
}
