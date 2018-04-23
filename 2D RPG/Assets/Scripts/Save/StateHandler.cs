using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateHandler : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(this);
		string keyName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + gameObject.name;
		if (PlayerPrefs.GetInt(keyName) == 0){
			gameObject.SetActive(false);
		}

	}
	
	// Update is called once per frame
	public void setActiveState(bool state) {
		string keyName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + gameObject.name;
		PlayerPrefs.SetInt(keyName, state ? -1 : 0);
		gameObject.SetActive(state);
	}
}
