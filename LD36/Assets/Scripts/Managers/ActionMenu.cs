using UnityEngine;
using System.Collections;

public class ActionMenu : MonoBehaviour {

    public Item item;

	public void UseItem()
    {
        GameManager.Instance.GetPlayer().UseItem(item);
        Close();
    }

    public void LookAt()
    {
        //Do Stuff
        Close();
    }

    public void Close()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

}
