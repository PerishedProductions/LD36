using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    public Slot[] slots;

    public void AddItem(Item itemToAdd)
    {
        Debug.Log(itemToAdd);
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].item = itemToAdd;
                slots[i].ChangeIcon();
                return;
            }
        }
    }
}
