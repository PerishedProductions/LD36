using UnityEngine;
using System.Collections;

public class Box : Interactable {

    public Item item;
    public override void Interact()
    {
        Debug.Log("I am a box you fool!");
        if( item != null)
        {
            GameManager.Instance.GetInventory().AddItem(item);
            item = null;
            DialogManager.Instance.Dialog("Bobba", "OMG i found a magnifying glass");
            //TODO: maybe do some stuff xD
        }
        
    }
}
