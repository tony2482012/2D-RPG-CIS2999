using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    #region Singleton
    public static Inventory instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion 

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
	public InventorySlot[] slots = new InventorySlot[4];
    public List<Item> items = new List<Item>();

    public int space = 4;

	void start () {
		//slots = GetComponentsInChildren<InventorySlot>();
	}
    public bool add( Item item)
    {
        if (items.Count >= space)
            return false;
       
        items.Add(item);
		slots [0].addItem (item);
        if(onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();

        return true;
    }

    public void remove (Item item)
    {
        items.Remove(item);

        if (onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
    }
}
