using UnityEngine;
using System.Collections;

public class Box : Interactable {
    
    public override void Interact()
    {
        DialogManager.Instance.Dialog("You search around in the box.", 0.04f);
        base.Interact();
    }

    public override void Interact(Item Useditem)
    {
        if( Useditem is MagnifyingGlass )
        {
            DialogManager.Instance.Dialog("After close observation you have concluded that this is indeed a box.", 0.04f);
        }
        else
        {
            base.Interact(Useditem);
        }
    }
}
