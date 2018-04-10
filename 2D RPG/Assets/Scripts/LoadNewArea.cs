﻿using System.Collections;
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

	void OnCollisionEnter2D(Collision2D collision){
		GetComponent<Collider> ().enabled = false;
	}
}