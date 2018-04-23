using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveThisClass : MonoBehaviour {

	public Player player;

    public void Save()
    {   
        SavePosition s = new SavePosition();
		s.x = player.transform.position.x;
		s.y = player.transform.position.y;
		s.z = player.transform.position.z;
        
        s.health = WizardControl.wizardHP;

        s.numberOfEnemies = Battleflow.enemysOnScreen; // TODO
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
}
