using UnityEngine;
using System.Collections;

public class MagnifyingGlass : Item {

    public override void SelectItem()
    {
        Debug.Log("Selected magnifying glass!");
    }

    public override void UseItem()
    {
        Debug.Log("Using magnifying glass!");
    }
}
