/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling an enemy in battle
 * This File is to test a generic enemy control file
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {
	[SerializeField] private StatCode hp;
	[SerializeField] public static float EnemyHP;
	[SerializeField] public static float EnemyAttPow;
	public Vector3 EnemyPos;
	public Transform damTextObj;
	[SerializeField] public int enemyTurn;
	// Use this for initialization
	void Start () {
		if (gameObject.name == "Snake(Clone)") {
			EnemyHP = 50;
			EnemyAttPow = 20;
			EnemyPos = transform.position;
		} else if (gameObject.name == "Slime(Clone)") {
			EnemyHP = 40;
			EnemyAttPow = 30;
			EnemyPos = transform.position;
		}
	}


	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 2) && (gameObject.name == "Snake(Clone)")) {
			GetComponent<Animator> ().SetTrigger ("SnakeBite1");
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);

			StartCoroutine (returnEnemy ());

		} 
		else if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 2) && (gameObject.name == "Dragon(Clone)")) {
			EnemyHP = 100;
			EnemyAttPow = 50;
			GetComponent<Animator> ().SetTrigger ("DragonSmash1");
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);

			StartCoroutine (returnEnemy ());
			Debug.Log (Battleflow.whichTurn);
		}
		else if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 2) && (gameObject.name == "Slime(Clone)"))
		{
			GetComponent<Animator> ().SetTrigger ("SlimeBash1");
			GetComponent<Transform> ().position = new Vector2 (1.0f, 5.00f);
			StartCoroutine (waitSeconds());
			GetComponent<Transform> ().position = new Vector2 (4.0f, -1.79f);

		
			StartCoroutine (returnEnemy ());
		}

		if ((Battleflow.damageDisplay == "y") && (gameObject.name == Battleflow.selectedEnemy))
		{
			EnemyHP -= Battleflow.currentDamage;
			Debug.Log (EnemyHP);
			Battleflow.damageDisplay = "n";

		}
		if (EnemyHP <= 0) {
			Destroy (gameObject);
			Battleflow.enemysOnScreen--;
		}
	}

	IEnumerator returnEnemy(){
		Battleflow.currentDamage = EnemyAttPow;
		yield return new WaitForSeconds (0.3f);
		WizardControl.wizardHP -= EnemyAttPow;
		//hp.MyCurrentValue -= 30;
		GetComponent<Transform> ().position = EnemyPos;
		Battleflow.whichTurn = 1;
		Instantiate (damTextObj, new Vector2 (4.6f, 2.24f), damTextObj.rotation);

	}

	IEnumerator waitSeconds(){

		yield return new WaitForSeconds (5.0f);
	}

	IEnumerator returnDragon()
	{
		yield return new WaitForSeconds (0.3f);
		WizardControl.wizardHP -= EnemyAttPow;
		hp.MyCurrentValue -= EnemyAttPow;
		GetComponent<Transform> ().position = new Vector2 (-4.18f, 1.45f );
	}

	void OnMouseDown(){
		Battleflow.selectedEnemy = gameObject.name;

	}
}
