using UnityEngine;
using System.Collections;

public class Door : ScreenTransitionCursor
{
    public bool Locked = true;
    public Sprite unlockedSprite;

    public override void Interact()
    {
        if( !Locked )
        {
            base.Interact();
        }
        else
        {
            DialogManager.Instance.Dialog("The door is locked tight, but you notice a small hole that may fit a small object in.", 0.04f);
        }
    }

    public override void Interact( Item Useditem)
    {
        if( Useditem is MagnifyingGlass)
        {
            DialogManager.Instance.Dialog("This seems to expand into more hallways of the pyramid.", 0.04f);
        }
        else if( Locked && Useditem is Key )
        {
            Locked = false;
            GameManager.Instance.GetInventory().RemoveItem(Useditem);
            ChangeSprite(unlockedSprite);
        }
        else
        {
            base.Interact(Useditem);
        }
    }

    public virtual void ChangeSprite(Sprite sprite)
    {
        this.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
