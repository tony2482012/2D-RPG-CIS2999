using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Anthony Yono

public class Player : Character 
{
    //to connect with the StateCode file
    [SerializeField]
    public StatCode hp;

    [SerializeField]
    private float initHealth = 100;

	// public int characterselect = 1; // Selena

    

    protected override void Start()
    {
        hp.Initialized(initHealth, initHealth);
        base.Start();

    }
	// Update is called once per frame
	protected override void Update () 
	{
		GetInput();

        //hp.MyCurrentValue = 100;

		base.Update ();
	}
		
	private void GetInput()
	{
		direction = Vector2.zero;

        //This is used for debugging only
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            hp.MyCurrentValue -= 10;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            hp.MyCurrentValue += 10;
        }
        
        //

		if (Input.GetKey(KeyCode.W)) 
		{
			direction += Vector2.up;
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			direction += Vector2.left;
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			direction += Vector2.down;
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			direction += Vector2.right;
		}
	}
}
