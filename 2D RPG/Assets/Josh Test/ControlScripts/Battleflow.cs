/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the flow of battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Battleflow : MonoBehaviour {
	public Transform snakeObj;
	public Transform slimeObj;
	public int enemy1Turn = 2;
	public int enemy2Tur = 3;
	public int enemy3Turn = 4;
	//public float enemyPosition1;
	//public float enemyPosition2;
	//public float enemyPosition3;
	//controls enemy targeting
	public static string selectedEnemy="";
	public static int enemysOnScreen = 0;
	public static string attButSelected ="n";


	//controls character turn
	public static int whichTurn = 1;
	//damage being done on this turn
	public static float currentDamage = 0;
	// should damage be displayed
	public static string damageDisplay = "n";

	public static string wizardStatus = "OK";

	// Use this for initialization
	void Start () {
		System.Random rnd = new System.Random ();
		int spawn1 = rnd.Next (1, 100);
		int spawn2 = rnd.Next (1, 100);
		int spawn3 = rnd.Next (1, 100);


		if (spawn1 >= 0) {
			Instantiate(snakeObj, new Vector2 (-3.0f, -0.0f), snakeObj.rotation);
			enemysOnScreen++;
		}
		if (spawn2 >= 30) {
			int enemyType = rnd.Next (1, 100);

			if (enemyType >= 100) {
				Instantiate (snakeObj, new Vector2 (-3.0f, -1.5f), snakeObj.rotation);
			} else if (enemyType < 100) {
				Instantiate (slimeObj, new Vector2 (-3.0f, -1.5f), slimeObj.rotation);
			}
				enemysOnScreen++;
		}
		if (spawn3 >= 80) {
			Instantiate (snakeObj, new Vector2 (-3.0f, -3.0f), snakeObj.rotation);
			enemysOnScreen++;
		}



	}

	// Update is called once per frame
	void Update () {
		if ((whichTurn == 1) && (wizardStatus == "dead")) 
		{
			Debug.Log (wizardStatus);
			whichTurn = 2;
		}


		if (enemysOnScreen == 0)
		{
			whichTurn = 1;
			EditorSceneManager.LoadScene ("NewForestNight");
		}

	}
}
