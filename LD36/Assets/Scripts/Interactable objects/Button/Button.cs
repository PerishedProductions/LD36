using UnityEngine;
using System.Collections;

public class Button : Interactable {

    public char character;
    public CodeDoor LinkedDoor;

    public override void Interact()
    {
        DialogManager.Instance.Dialog("You pressed a weird button.", 0.04f);
        if( !LinkedDoor )
        {
            LinkedDoor.InsertKey(character);
        }
    }
}
