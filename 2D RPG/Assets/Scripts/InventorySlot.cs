
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour {
    public Image pic;
    Item item;

    public void addItem(Item newItem)
    {
        item = newItem;
        
        pic.sprite = item.icon;
        
        pic.enabled = true;

    }

    public void clearSlot()
    {
        item = null;

        pic.sprite = null;

        pic.enabled = false;

    }

}
