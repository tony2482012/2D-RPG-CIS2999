// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// //Selena

// public class MainMenu : MonoBehaviour {

//     public string mainScene;
//     //public string levelSelect;
//     //public string whatever;
//     //public GameObject mainMenuCanvas;
//     //public bool isStart;
//     //public bool isQuit;
//     public GameObject loadButton;

//     public GameObject mainMenuCanvas;
//     //public GameObject camera;
//     //public GameObject pauseMenuCanvas;
//     //public bool isPaused;
//     //public string mainMenu;
//     public static string dataPath = string.Empty;


// 	// Use this for initialization
// 	public void NewGame () {
        
//         mainMenuCanvas.SetActive(false);
//         //camera.SetActive(true);
//         SceneManager.LoadScene("CombatTestScene");


//         //Debug.Log("Click");
		
// 	}



//     private void Awake()
//     {

//         dataPath = System.IO.Path.Combine(Application.persistentDataPath, "chars.json");

//     }

//     public void LoadGame() {

//         SaveData.Load(dataPath);
        
//     }

//     //// Update is called once per frame
//     //public void Quit () {

//     //       Debug.Log("Game Exited");
//     //       //Application.Quit();

//     //       //SceneManager.LoadScene(Menu);



//     //}
// }
