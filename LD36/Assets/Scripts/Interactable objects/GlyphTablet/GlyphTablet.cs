using UnityEngine;
using System.Collections;

public class GlyphTablet : Interactable {

    public override void Interact()
    {
        if (GameManager.Instance.GetInventory().SearchInventory(typeof(Torch)))
        {
            DialogManager.Instance.Dialog("You look at the tablet", 0.04f);
            base.Interact();
        }
        else
        {
            DialogManager.Instance.Dialog("You found something that looked like a tablet, but it is too dark to identify properly.", 0.04f);
        }
    }

    public override void Interact(Item Useditem)
    {
        if (GameManager.Instance.GetInventory().SearchInventory(typeof(Torch)))
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
        else
        {
            DialogManager.Instance.Dialog("It is too dark to see anything.", 0.04f);
        }
    }

}
