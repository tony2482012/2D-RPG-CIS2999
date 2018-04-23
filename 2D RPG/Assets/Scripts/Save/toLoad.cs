using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLoad : MonoBehaviour {

	public static Player player;

	public void Loading() {
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
            SimpleHealthBar.currentFraction = (float) s.healthBarFraction; // TODO
        }
	}
}
