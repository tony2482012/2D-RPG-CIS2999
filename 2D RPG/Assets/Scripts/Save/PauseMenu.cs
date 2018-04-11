using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Selena

public class PauseMenu : MonoBehaviour
{

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
    
    [SerializeField] public string isBattle;
    public StatCode hp;
    public SimpleHealthBar shb;
    public float health ;
    public double fraction;
    public int numberOfEnemies;
    public int spawn11;
    public int spawn21;
    public int spawn31;
    public string gameSettings;
    
    public toLoad loading;
    public SaveThisClass saving;

    void Update()
    {
        if (isMainMenu)
        {
            mainMenuCanvas.SetActive(true);
            isPaused = false;
            Time.timeScale = 0f;

            if (isInGame)
            {
                SceneManager.LoadScene("NewForestNight");
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

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            isPaused = true;
        }
    }

    public void Resume()
    {
        isPaused = false;
        isInGame = false;
    }
   
    public void Save()
    {
        // SaveThisClass saving = new SaveThisClass();
        // saving.Save();

        SavePosition s = new SavePosition();
		s.x = player.transform.position.x;
		s.y = player.transform.position.y;
		s.z = player.transform.position.z;
        
        s.health = WizardControl.wizardHP;

        s.numberOfEnemies = Battleflow.enemysOnScreen; // TODO

        // s.spawn11 = Battleflow.s;

        s.healthBarFraction = SimpleHealthBar.currentFraction; // TODO

        if(SceneManager.GetActiveScene().buildIndex == 1) {
            s.isBattle = true;
        } else {
            s.isBattle = false;
        }

        

		Debug.Log(s);
        
		Debug.Log(JsonUtility.ToJson(s));

		PlayerPrefs.SetString("PlayerLocation", JsonUtility.ToJson(s));
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

            WizardControl.wizardHP = s.health;
            Battleflow.enemysOnScreen = s.numberOfEnemies; // TODO
            SimpleHealthBar.currentFraction = (float) s.healthBarFraction; // TODO????????????????????????????????????????????????????????????
        }
    }

    public void ButtonNewGame()
    {
        isMainMenu = false;
    }

    public void Quit()
    {
        isMainMenu = true;
    }

    public void QuitGame () {
        Application.Quit();
    }
}
