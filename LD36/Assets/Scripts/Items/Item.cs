using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public Sprite itemIcon;
    public string description = "";
    public string itemName = "";

    // Use this for initialization
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void Awake()
    {

    }

    protected virtual void OnGUI()
    {

    }

    public virtual string ObtainItemName()
    {
        return itemName;
    }

    public virtual void ReadDescription()
    {
        if( description != "")
        {
            DialogManager.Instance.Dialog(description, 0.04f);
        }
    }

    public virtual void UseItem()
    {
        return;
    }
}
