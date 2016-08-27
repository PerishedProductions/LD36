using UnityEngine;
using System.Collections;

public class Book : Item
{

    public override void SelectItem()
    {
        Debug.Log("Selected Book glass!");
    }

    public override void UseItem()
    {
        Debug.Log("Using Book glass!");
    }
}
