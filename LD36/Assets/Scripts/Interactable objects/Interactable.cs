using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    public bool dialog;
    public string actorName;
    public string message;
    public Item item;

    // Use this for initialization
    protected virtual void Start ()
    {
	
	}
	
	// Update is called once per frame
	protected virtual void Update ()
    {
	
	}

    protected virtual void Awake()
    {

    }

    protected virtual void OnGUI()
    {

    }

    public virtual void Interact()
    {
        if (item != null)
        {
            if (GameManager.Instance.GetInventory().AddItem(item))
            {
                if (dialog)
                {
                    if (message == "")
                    {
                        DialogManager.Instance.Dialog(actorName, "Obtained " + item.ObtainItemName(), 0.02f);
                    }
                    else
                    {
                        DialogManager.Instance.Dialog(actorName, message, 0.02f);
                    }

                }
                item = null;
            }
            else
            {
                DialogManager.Instance.Dialog("Unable to obtain " + item.ObtainItemName() + " because the backpack is full.", 0.04f);
            }
        }
        else
        {
            DialogManager.Instance.Dialog("Nothing happends", 0.04f);
        }
    }

    public virtual void Interact( Item Useditem )
    {
        DialogManager.Instance.Dialog("Nothing happends when using " + Useditem.ObtainItemName() + " with this object.", 0.04f);
    }
}
