using UnityEngine;
using System.Collections;

public class DialogManager : MonoBehaviour {

    private static DialogManager _instance;

    public static DialogManager Instance
    {

        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("DialogManager");
                go.AddComponent<DialogManager>();
            }

            return _instance;
        }

    }

    void Awake()
    {
        _instance = this;
    }

    void Dialog(string actor, string text)
    {
        
    }

}
