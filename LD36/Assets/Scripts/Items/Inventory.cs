using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    public Slot[] slots;

    public bool AddItem(Item itemToAdd)
    {
        Debug.Log(itemToAdd);
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].item = itemToAdd;
                slots[i].ChangeIcon();
                if (itemToAdd is Torch)
                    ToggleTorch(itemToAdd);
                return true;
            }
        }

        return false;
    }

    public void RemoveItem( Item itemToRemove )
    {
        Debug.Log(itemToRemove);
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == itemToRemove)
            {
                slots[i].item = null;
                slots[i].ChangeIcon();
                if (itemToRemove is Torch)
                    ToggleTorch(itemToRemove);
            }
        }
    }

    public void ToggleTorch(Item itemToCheck)
    {
        PlayerController player = GameManager.Instance.GetPlayer();
        if (!player.torchlight.gameObject.activeSelf)
        {
            player.torchlight.gameObject.SetActive(true);
            player.anim.SetBool("hasTorch", true);
        }
        else
        {
            player.torchlight.gameObject.SetActive(false);
            player.anim.SetBool("hasTorch", false);
        }
    }

}
