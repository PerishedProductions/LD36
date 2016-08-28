using UnityEngine;
using System.Collections;

public class Button : Interactable {

    public char character;
    public CodeDoor LinkedDoor;

    public override void Interact()
    {
        DialogManager.Instance.Dialog("You pressed a weird button.", 0.01f);
        if( LinkedDoor != null )
        {
            LinkedDoor.InsertKey(character);
        }
    }

    public override void Interact(Item Useditem)
    {
        if( Useditem is MagnifyingGlass )
        {
            DialogManager.Instance.Dialog("You notice a weird shape on the button. What could it mean?", 0.03f);
        }
        else
        {
            base.Interact(Useditem);
        }
    }
}
