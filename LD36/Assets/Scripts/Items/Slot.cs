using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Slot : MonoBehaviour {

    public Item item;
    public Image image;

    void Start()
    {
        image = this.GetComponent<Image>();
    }

    public void ChangeIcon()
    {
        if (item != null)
        {
            image.sprite = item.itemIcon;
            image.color = new Color(255, 255, 255, 255);
        }
    }
}
