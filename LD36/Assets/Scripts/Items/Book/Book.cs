using UnityEngine;
using System.Collections;

public class Book : Item
{
    public override void UseItem()
    {
        UIManager.Instance.OpenBook();
    }
}
