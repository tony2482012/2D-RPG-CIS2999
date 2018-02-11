using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

	private BaseCharacterClass class1 = new BaseMageClass();
	private BaseCharacterClass class2 = new BaseWarriorClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		//mage
		GUILayout.Label (class1.ChacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.Intellect.ToString());
		GUILayout.Label (class1.Stamina.ToString());
		GUILayout.Label (class1.Endurance.ToString());
		GUILayout.Label (class1.Strength.ToString());

		//Warrior
		GUILayout.Label (class2.ChacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
		GUILayout.Label (class2.Intellect.ToString());
		GUILayout.Label (class2.Stamina.ToString());
		GUILayout.Label (class2.Endurance.ToString());
		GUILayout.Label (class2.Strength.ToString());

	}
}
