using UnityEngine;
using System.Collections;

public enum ItemTypes { Potion, Tool, SomethingSomething}

[CreateAssetMenu(fileName = "InventoryItem", menuName = "Inventory/Item", order = 1)]
public class InventoryItem : ScriptableObject {

    public string itemName;
    public Sprite itemIcon;
    public ItemTypes itemType; 
	
}
