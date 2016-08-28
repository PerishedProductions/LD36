using UnityEngine;
using UnityEngine.UI;
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="actor">The name of the person speaking</param>
    /// <param name="text">What the person speaking is saying</param>
    /// <param name="textspeed">how fast the text goes(lower is faster)</param>
    public void Dialog(string actor, string text, float textspeed)
    {
        DialogBox dialogBox = GameObject.Find("DialogBox").GetComponent<DialogBox>();
        dialogBox.panel.SetActive(true);
        dialogBox.actor.text = actor;
        StartCoroutine(TypeText(text, dialogBox, textspeed));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text">What the person speaking is saying</param>
    /// <param name="textspeed">how fast the text goes(lower is faster)</param>
    public void Dialog(string text, float textspeed)
    {
        DialogBox dialogBox = GameObject.Find("DialogBox").GetComponent<DialogBox>();
        dialogBox.panel.SetActive(true);
        dialogBox.actor.text = "";
        StartCoroutine(TypeText(text, dialogBox, textspeed));
    }

    IEnumerator TypeText(string message, DialogBox dialogBox, float letterPause)
    {
        dialogBox.dialog.text = "";
        foreach (char letter in message.ToCharArray())
        {
            dialogBox.dialog.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
        yield return StartCoroutine(WaitForMouseDown(0));
        dialogBox.panel.SetActive(false);
    }

    IEnumerator WaitForMouseDown(int mouseButton)
    {
        while (!Input.GetMouseButtonDown(mouseButton))
            yield return null;
    }
}
