using UnityEngine;
using System.Collections;

public class CodeDoor : Door {

    public string code;
    private int progress =  0;

    public void InsertKey( char key )
    {
        if( code[progress] == key && Locked )
        {
            DialogManager.Instance.Dialog("You hear a faint noise of a mechanism releasing a gear.", 0.01f);
            progress++;
            if( progress == code.Length)
            {
                DialogManager.Instance.Dialog("You hear a loud noise coming from the door!", 0.04f);
                base.ChangeSprite(unlockedSprite);
                Locked = false;
            }
        }
        else
        {
            DialogManager.Instance.Dialog("A faint noise of a mechanism falling back into its place echoed across the room.", 0.01f);
            progress = 0;
        }
    }

    public override void Interact()
    {
        if (Locked)
        {
            DialogManager.Instance.Dialog("You try to open the door, but the door does't budge.", 0.03f);
        }
        else
        {
            base.Interact();
        }
        
    }

    public override void Interact(Item Useditem)
    {
        if( Useditem is MagnifyingGlass)
        {
            DialogManager.Instance.Dialog("You see nothing interesting on the door.", 0.02f);
        }
        else
        {
            base.Interact(Useditem);
        }

    }
}
