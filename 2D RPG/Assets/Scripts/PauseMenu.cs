using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Selena

public class PauseMenu : MonoBehaviour
{
    //public string mainMenu;
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
    void Update()
    {
        if (isMainMenu)
        {
            mainMenuCanvas.SetActive(true);
            isPaused = false;
            Time.timeScale = 0f;

        }
        else
        {
            mainMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            isMainMenu = false;
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
        }

    }

    public void Resume()
    {

        isPaused = false;

    }

    public void Save()
    {

        //object[] obj = GameObject.FindObjectsOfType(typeof(GameObject));

        //foreach (object o in obj)
        //{
        //    GameObject g = (GameObject)o;
        //    Debug.Log(g.ToString());
        //    //Debug.Log(JsonUtility.ToJson(o));



        //}

    }

    public void ButtonNewGame()
    {

        isMainMenu = false;
        SceneManager.LoadScene("CombatTestScene*");

    }

    public void Quit()
    {

        isMainMenu = true;
        isPaused = false;

    }
}
