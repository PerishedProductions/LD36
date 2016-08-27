using UnityEngine;
using System.Collections;

public class Box : Interactable {

    public Item item;
    public override void Interact()
    {
        Debug.Log("I am a box you fool!");
        PlayerController player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if( item != null)
        {
            GameManager.Instance.GetInventory().AddItem(item);
            item = null;
            //TODO: maybe do some stuff xD
        }
        
    }
}
