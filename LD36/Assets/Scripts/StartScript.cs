using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        GameManager.Instance.GetPlayer();
        GameManager.Instance.GetUI();
        Destroy(this.gameObject);
	}
}
