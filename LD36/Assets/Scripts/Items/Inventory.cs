using UnityEngine;
using System.Collections;
using System;

public class Inventory : MonoBehaviour {

    public Slot[] slots;

    public void UpdateInventory(InventoryItem itemToAdd)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                slots[i].item = itemToAdd;
                break;
            }
        }
    }
}
