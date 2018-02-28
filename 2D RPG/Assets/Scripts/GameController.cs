using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Selena

public class GameController : MonoBehaviour {

    public Button saveButton;
    //public Button loadButton;

    public GameObject playPrefab;

    public static string dataPath = string.Empty;

    private void Awake() {

        dataPath = System.IO.Path.Combine(Application.persistentDataPath, "chars.json");
        
    }

 //   // Use this for initialization
 //   void Start () {
		
	//}

    public static Character CreateChars(string path, GameObject prefab, Vector3 position, Quaternion rotation) {

        GameObject go = Instantiate(prefab, position, rotation) as GameObject;
        Character chars = go.GetComponent<Character>() ?? go.AddComponent<Character>();
        return chars;

    }

    public void Save () {
        SaveData.Save(dataPath, SaveData.charContainer);
    }

    //public void Load () {

    //    SaveData.Load(dataPath);

    //}

}
