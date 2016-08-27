using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public Sprite itemIcon;

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

    public virtual void SelectItem()
    {
        Debug.Log("Select base item!");
    }

    public virtual void UseItem()
    {
        Debug.Log("Using base item!");
    }
}
