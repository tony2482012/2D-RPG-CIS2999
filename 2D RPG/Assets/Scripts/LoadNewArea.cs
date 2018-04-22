using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour {

    public string LeveltoLoad;

	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {            
            Application.LoadLevel(LeveltoLoad);
        }
      
    }

// <<<<<<< HEAD
    private Collider storedGameObject;


    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Collider>().enabled = false;
            Application.LoadLevel("NewForestNight");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
// =======

	// void OnCollisionEnter2D(Collision2D collision){
	// 	GetComponent<Collider> ().enabled = false;
	// }


// >>>>>>> 9776e4125dd6bd5512801e41ca93c381e59fd890

            if (Input.GetKey(KeyCode.A))
            {
                GetComponent<Collider>().enabled = false;
            Application.LoadLevel("NewForestNight");
        }
        
    }
}