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

    public List<Item> items = new List<Item>();

    public int space = 4;


    public bool add( Item item)
    {
        if (items.Count >= space)
            return false;
       
        items.Add(item);

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
