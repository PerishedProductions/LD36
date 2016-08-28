using UnityEngine;
using System.Collections;

public class MummyBox : Interactable {
    
    public override void Interact()
    {
        DialogManager.Instance.Dialog("You open up the Sarcophagus", 0.04f);
        base.Interact();
    }

    public override void Interact(Item Useditem)
    {
        if( Useditem is MagnifyingGlass )
        {
            DialogManager.Instance.Dialog("After closer examination you have concluded that this is Sarcophagus.", 0.04f);
        }
        else
        {
            base.Interact(Useditem);
        }
    }
}
