using UnityEngine;
using System.Collections;

public class CodeDoor : Door {

    public string code;
    private int progress =  0;

    public void InsertKey( char key )
    {
        if( code[progress] == key && Locked )
        {
            DialogManager.Instance.Dialog("You hear a faint noise of a mechanism releasing a gear.", 0.02f);
            progress++;
            if( progress == code.Length)
            {
                DialogManager.Instance.Dialog("You hear a loud noise coming from the door.", 0.04f);
                Locked = false;
            }
        }
        else
        {
            DialogManager.Instance.Dialog("A faint noise of a mechanism falling back into its place echoed across the room.", 0.02f);
            progress = 0;
        }
    }
}
