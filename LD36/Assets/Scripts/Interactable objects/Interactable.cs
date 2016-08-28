using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour {

    public bool dialog;
    public string actorName;
    public string message;

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
        Debug.Log("Base interactable object");
    }

    public virtual void Interact( Item Useditem )
    {
        Debug.Log("Base interactable got interacted with item: " + Useditem);
    }
}
