// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GameSave : MonoBehaviour {

// 	public GameObject player;

// 	// Use this for initialization
// 	void Load () {
// 		RestoreGame();
// 	}

// 	void RestoreGame() {
// 		string p = PlayerPrefs.GetString("PlayerLocation");
// 		if (p != null && p.Length > 0) {
// 			SavePosition s = JsonUtility.FromJson<SavePosition> (p);
// 			if (s != null) {
// 				Vector3 position = new Vector3();
// 				position.x = s.x;
// 				position.y = s.y;
// 				position.z = s.z;
// 				player.transform.position = position;
// 			}
// 		}
// 	}
	
// 	// Update is called once per frame
// 	void Update () {
		
// 			SaveGame();
		
// 	}

// 	public void SaveGame() {
// 		SavePosition s = new SavePosition();
// 		s.x = player.transform.position.x;
// 		s.y = player.transform.position.y;
// 		s.z = player.transform.position.z;

// 		string json = JsonUtility.ToJson(s);
// 		Debug.Log(json);

// 		PlayerPrefs.SetString("PlayerLocation", json);

// 	}
// }
