using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Item item;
    public Image image;

    private bool isOver;

    void Awake()
    {   
        image = this.GetComponent<Image>();
    }

    void Update()
    {
        if (item != null && isOver && Input.GetMouseButtonDown(0))
        {
            UIManager.Instance.ActionMenu(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            GameManager.Instance.GetActionMenu().item = item;
        }
    }

    public void ChangeIcon()
    {
        if (item != null)
        {
            image.sprite = item.itemIcon;
            image.color = new Color(255, 255, 255, 255);
        }
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        isOver = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        isOver = false;
    }
}
