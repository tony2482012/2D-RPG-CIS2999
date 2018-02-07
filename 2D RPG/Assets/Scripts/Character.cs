using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Character : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Animator animator;

	protected Vector2 direction;

	// Use this for initialization
	protected virtual void Start () 
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	protected virtual void Update () 
	{
		Move ();
	}

	public void Move()
	{
		transform.Translate(direction * speed * Time.deltaTime);

		AnimateMovement (direction);
	}

	public void AnimateMovement(Vector2 direction)
	{
		animator.SetFloat ("x", direction.x);
		animator.SetFloat ("y", direction.y);
	}


    //Selena

    public CharData data = new CharData();
    public string title = "actor";
    public float health = 100;

    public void StoreData() {
        data.title = title;
        data.pos = transform.position;
        data.health = health;
    }

    public void LoadData() {
        title = data.title;
        transform.position = data.pos;
        health = data.health;
    }

    public void ApplyData () {

        //SaveData.addCharData(data);

    }

    void OnEnable() {

        SaveData.OnLoaded += LoadData;
        SaveData.OnBeforeSave += StoreData;
        //SaveData.OnBeforeSave += ApplyData;

    }

    void OnDisable() {

        SaveData.OnLoaded -= LoadData;
        SaveData.OnBeforeSave -= StoreData;
        //SaveData.OnBeforeSave += ApplyData;

    }
}

[Serializable]
public class CharData{
    public string title;
    public Vector3 pos;
    public float health;

}



