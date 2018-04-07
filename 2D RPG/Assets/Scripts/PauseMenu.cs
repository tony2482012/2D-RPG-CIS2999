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
    public bool isInGame;
    public GameObject pauseMenuCanvas;
    public GameObject mainMenuCanvas;
    public GameObject inGameCanvas;
    public GameObject NewGameButton;
    public GameObject SaveGameButton;
    public GameObject ResumeButton;
    public GameObject LoadButton;
    public GameObject QuitButton;
    public GameObject QuitMainButton;
    public GameObject player;
    // public Scene battle;
    [SerializeField] public string isBattle;
    public StatCode hp;
    public SimpleHealthBar shb;
    public float health ;
    public double fraction;
    public int numberOfEnemies;
    
    public string gameSettings;

    // Update is called once per frame
    void Update()
    {
        if (isMainMenu)
        {
            mainMenuCanvas.SetActive(true);
            isPaused = false;
            //isInGame = false;
            Time.timeScale = 0f;
            if (isInGame)
            {
                SceneManager.LoadScene("NewForestNight");
                //isInGame = false;
            }
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
            isInGame = true;
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
        }

        


        //if (isInGame)
        //{
        //    inGameCanvas.SetActive(true);
        //    isMainMenu = false;
        //    isPaused = false;
        //    Time.timeScale = 0f;
        //}
        //else
        //{
        //    inGameCanvas.SetActive(false);
        //}

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
            //isInGame = true;
        }

    }

    public void Resume()
    {
        isPaused = false;
        isInGame = false;

    }

    
    public void Save()
    {

        //object[] obj = GameObject.FindObjectsOfType(typeof(GameObject));

        //foreach (object o in obj)
        //{
        //    GameObject g = (GameObject)o;
        //    Debug.Log(g.ToString());
        
        SavePosition s = new SavePosition();
		s.x = player.transform.position.x;
		s.y = player.transform.position.y;
		s.z = player.transform.position.z;
        
        s.health = WizardControl.wizardHP;
        // s.health = player.hp.MyCurrentValue;

        s.numberOfEnemies = Battleflow.enemysOnScreen;
        s.healthBarFraction = SimpleHealthBar.currentFraction;

        if(SceneManager.GetActiveScene().buildIndex == 1) {
            s.isBattle = true;
        } else {
            s.isBattle = false;
        }

		// gameSettings = JsonUtility.ToJson(s);
        // JsonUtility.ToJson(isBattle.ToString());
		Debug.Log(s);
        
		Debug.Log(JsonUtility.ToJson(s));

		PlayerPrefs.SetString("PlayerLocation", JsonUtility.ToJson(s));
        // PlayerPrefs.SetString(isBattle, json);

    }

    public void Load() {
        Restore();
        isMainMenu = false;

    }
    public void Restore() {
        string p = PlayerPrefs.GetString("PlayerLocation");
        SavePosition s = JsonUtility.FromJson<SavePosition> (p);
        
        Debug.Log(p);
        Debug.Log(s);

        if (s != null) {
            Vector3 position = new Vector3();
            position.x = s.x;
            position.y = s.y;
            position.z = s.z;
            player.transform.position = position;

            if (s.isBattle == true) {
                SceneManager.LoadScene(1);
            }
            // hp.MyCurrentValue = s.health;
            WizardControl.wizardHP = s.health;
            
            Battleflow.enemysOnScreen = s.numberOfEnemies;
            SimpleHealthBar.currentFraction = (float) s.healthBarFraction;
        }
    }

    public void ButtonNewGame()
    {
        // SceneManager.LoadScene("CombatTestScene*");
        isMainMenu = false;

    }

    //public void InGameNewGame() {
        
    //}

    public void Quit()
    {
        isMainMenu = true;


        //isInGame = true;

    }

    public void QuitGame () {
        //Debug.Log("L");
        Application.Quit();
    }
}
