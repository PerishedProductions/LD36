using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public Item item;
    public Image image;

    private bool isOver;

    void Start()
    {
        image = this.GetComponent<Image>();
    }

    void Update()
    {
        if (isOver && Input.GetMouseButtonDown(0) && item != null)
        {
            GameManager.Instance.OpenActionMenu(Camera.main.ScreenToWorldPoint(Input.mousePosition));
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
        Debug.Log("Mouse enter");
        isOver = true;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        isOver = false;
    }
}
