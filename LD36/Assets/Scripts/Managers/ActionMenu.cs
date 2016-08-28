﻿using UnityEngine;
using System.Collections;

public class ActionMenu : MonoBehaviour {

    public Item item;

	public void UseItem()
    {
        if (item is Book)
        {
            item.UseItem();
        }
        else
        {
            GameManager.Instance.GetPlayer().UseItem(item);
        }
        Close();
    }

    public void LookAt()
    {
        item.ReadDescription();
        Close();
    }

    public void Close()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

}
