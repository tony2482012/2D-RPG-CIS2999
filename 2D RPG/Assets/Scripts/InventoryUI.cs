using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour {

    public Transform itemsParent;
    Inventory inventory;

	InventorySlot[] slots;
	// Use this for initialization
	void Start () {
		inventory = Inventory.instance;
        inventory.onItemChangedCallBack += updateUI;

		slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void updateUI()
    {
        Debug.Log("Updating UI");

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].addItem(inventory.items[i]);
            }
            else
            {
                slots[i].clearSlot();
            }
                
        }
    }
}
