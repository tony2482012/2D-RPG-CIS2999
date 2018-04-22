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
    // public GameObject inGameCanvas;
    public GameObject NewGameButton;
    public GameObject SaveGameButton;
    public GameObject ResumeButton;
    public GameObject LoadButton;
    public GameObject QuitButton;
    public GameObject QuitMainButton;
    public GameObject player;
    public bool isDied;

    [SerializeField] public string isBattle;
    public double fraction;
    void Update()
    {
        ifDied();
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

        if (isDied && isInGame)
        {
            isMainMenu = false;
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
            Debug.Log(Battleflow.enemyType);
        }
    }

    public void Resume()
    {
        isPaused = false;
        isInGame = false;
    }

    public void Save()
    {
        SavePosition s = new SavePosition();
        s.x = player.transform.position.x;
        s.y = player.transform.position.y;
        s.z = player.transform.position.z;

        s.health = WizardControl.wizardHP;

        s.numberOfEnemies = Battleflow.enemysOnScreen;

        s.healthBarFraction = SimpleHealthBar.currentFraction;
        s.turnNumber = Battleflow.whichTurn;
        s.isWizardDead = Battleflow.wizardStatus;
        s.enemyHealth = EnemyControl.EnemyHP;
        s.enemyAttack = EnemyControl.EnemyAttPow;
        s.enemyType = Battleflow.enemyType;
        s.spawn1 = Battleflow.spawn1;
        s.spawn2 = Battleflow.spawn2;
        s.spawn3 = Battleflow.spawn3;

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            s.isBattle = true;
        }
        else
        {
            s.isBattle = false;
        }

        Debug.Log(s);

        Debug.Log(JsonUtility.ToJson(s));

        PlayerPrefs.SetString("GameStats", JsonUtility.ToJson(s));
    }

    public void Load()
    {
        Restore();
        isMainMenu = false;
    }

    public void Restore()
    {
        string p = PlayerPrefs.GetString("GameStats");
        SavePosition s = JsonUtility.FromJson<SavePosition>(p);


        Vector3 position = new Vector3();
        position.x = s.x;
        position.y = s.y;
        position.z = s.z;
        player.transform.position = position;

        if (s.isBattle == true)
        {
            SceneManager.LoadScene(1);
        }

        WizardControl.wizardHP = s.health;
        Battleflow.enemysOnScreen = s.numberOfEnemies;
        SimpleHealthBar.currentFraction = (float)s.healthBarFraction;
        Battleflow.whichTurn = s.turnNumber;
        Battleflow.wizardStatus = s.isWizardDead;
        EnemyControl.EnemyHP = s.enemyHealth;
        EnemyControl.EnemyAttPow = s.enemyAttack;
        Battleflow.enemyType = s.enemyType;
        Battleflow.spawn1 = s.spawn1;
        Battleflow.spawn2 = s.spawn2;
        Battleflow.spawn3 = s.spawn3;

        Debug.Log(p);


    }

    public void ButtonNewGame()
    {
        isMainMenu = false;
        isInGame = true;
        PlayerPrefs.DeleteAll();
    }

    public void ifDied()
    {
        // Scene scenes = SceneManager.GetActiveScene();
        if ((EnemyControl.EnemyHP < 0 || Battleflow.wizardStatus == "dead") && isInGame)
        {
            isDied = true;
        }

    }

    public void Quit()
    {
        isMainMenu = true;
        // isDied = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
