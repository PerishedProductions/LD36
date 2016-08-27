using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class UIManager : MonoBehaviour {

    private static UIManager _instance;

    public static UIManager Instance
    {

        get
        {
            if (_instance == null)
            {
                GameObject go = (GameObject)Instantiate(Resources.Load("UI"));
                _instance = go.GetComponent<UIManager>();
            }

            return _instance;
        }

    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _instance = this;
    }

    public void ActionMenu(Vector3 mousePosition)
    {
        GameObject canvas = GameObject.Find("ActionCanvas");
        canvas.transform.position = mousePosition;
        canvas.transform.GetChild(0).gameObject.SetActive(true);
    }
}
