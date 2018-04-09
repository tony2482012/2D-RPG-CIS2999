/* Joshua Bunnell
 * Updated Jan 28 2018
 * C# script for controlling the wizard in battle
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour {
	[SerializeField] public  static float wizardHP = 100; // Selena - made serializable
	public static float wizardMaxHP = 100;

	public Transform damTextObj;
	public Transform fireballObj;

    //to connect with the StateCode file
    [SerializeField]
    private StatCode hp;


    [SerializeField]
    private float initHealth = 100;

    [SerializeField]
    private StatCode mana;

    [SerializeField]
    private float initMana = 100;

    // Use this for initialization
    void Start () {
        hp.Initialized(initHealth, initHealth);
        
        
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (wizardHP <= 0) 
		{
			Battleflow.wizardStatus = "dead";
			Debug.Log (Battleflow.wizardStatus);
			Debug.Log (Battleflow.whichTurn);
			Destroy (gameObject);	
		}

		if ((Input.GetKeyDown ("1")) && (Battleflow.whichTurn == 1))  {

            
            Battleflow.currentDamage = 30;
			GetComponent<Animator> ().SetTrigger ("WizardMagic1");
			Instantiate (fireballObj, new Vector2 (7.0f, -.21f), fireballObj.rotation);
			StartCoroutine (returnWizard ());
            hp.MyCurrentValue -= 30;
           
        }


	}

	IEnumerator returnWizard()
	{
		Debug.Log (Battleflow.selectedEnemy);
		yield return new WaitForSeconds (2);
		Battleflow.damageDisplay = "y";
		Instantiate (damTextObj, new Vector2 (-3.0f, 2.0f), damTextObj.rotation);
		Battleflow.whichTurn = 2;


	}
}
