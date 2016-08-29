using UnityEngine;
using System.Collections;

public class GlyphTablet : Interactable {

    public override void Interact()
    {
        DialogManager.Instance.Dialog("You look at the tablet", 0.04f);
        base.Interact();
    }

    public override void Interact(Item Useditem)
    {
        if (Useditem is MagnifyingGlass)
        {
            DialogManager.Instance.Dialog("After closer examination you realize you don't understand what is written on the tablet.", 0.04f);
            DialogManager.Instance.Dialog("thinking about it you realize these symbols look a lot like the ones in your book.", 0.04f);
        }
        else if (Useditem is Book)
        {
            UIManager.Instance.OpenBookAndTablet();
        }
        else
        {
            base.Interact(Useditem);
        }
    }

}
