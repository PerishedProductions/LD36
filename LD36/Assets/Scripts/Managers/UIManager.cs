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
        GameObject canvas = GameObject.Find("ActionBox");
        canvas.transform.position = mousePosition;
        canvas.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void OpenBook()
    {
        GameObject book = GameObject.Find("Book").transform.GetChild(0).gameObject;
        book.SetActive(true);
    }

    public void OpenBookAndTablet()
    {
        GameObject book = GameObject.Find("Book").transform.GetChild(0).gameObject;
        GameObject tablet = GameObject.Find("CodeTablet").transform.GetChild(0).gameObject;
        book.SetActive(true);
        tablet.SetActive(true);
    }
}
