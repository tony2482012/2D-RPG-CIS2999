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
<<<<<<< HEAD

	void OnCollisionEnter2D(Collision2D collision){
		GetComponent<Collider> ().enabled = false;
	}
=======
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Collider>().enabled = false;
    }

>>>>>>> c0a96a6a72462c51280bbd60b8e726e9f2bfe54f
}