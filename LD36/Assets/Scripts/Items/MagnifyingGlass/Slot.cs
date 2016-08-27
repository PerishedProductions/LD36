using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Slot : MonoBehaviour {

    public InventoryItem item;

    public Image image;

    void Start()
    {
        image = this.GetComponent<Image>();
    }

    void Update()
    {
        if (item != null)
        {
            image.sprite = item.itemIcon;
        }
    }
	
}
