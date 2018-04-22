using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
<<<<<<< HEAD
    public static int playerCurrentHealth;
=======
    public int playerCurrentHealth;
	Inventory inventory;
	SimpleHealthBar health = SimpleHealthBar.instance;
>>>>>>> codys-branch-3/18

	// Use this for initialization
	void Start ()
    {
        playerCurrentHealth = playerMaxHealth;	
		inventory = Inventory.instance;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

		if (Input.GetKeyDown("u")) {
			for(int i = 3; i > -1; i--) {
				if (inventory.slots [i].pic.sprite != null) {
					inventory.slots [i].clearSlot ();
					playerCurrentHealth += 30;
					break;
				}

			}
		}
			
	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }

}
