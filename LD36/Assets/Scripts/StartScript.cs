using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

    public Item item;

    // Use this for initialization
    void Awake () {
        //GameManager.Instance.GetPlayer();
        GameManager.Instance.GetUI();
        GameManager.Instance.GetInventory().AddItem(item);
        item = null;
        Destroy(this.gameObject);
	}

}
