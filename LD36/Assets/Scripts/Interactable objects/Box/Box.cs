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
            if (dialog)
            {
                DialogManager.Instance.Dialog(actorName, message);
            }
            //TODO: maybe do some stuff xD
        }       
    }

    public override void Interact(Item Useditem)
    {
        if( Useditem is MagnifyingGlass )
        {
            DialogManager.Instance.Dialog("After close observation you have concluded that this is indeed a box.");
        }

    }
}
