using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public Item item;

    public void pickUp()
    {
        Debug.Log("Picking up item");
        
        bool pickedUp = Inventory.instance.add(item);
        if(pickedUp)
            Destroy(gameObject);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //if(collider.gameObject.name == "PlayerCharacter")
        {
            pickUp();
            
        }
    }

}
