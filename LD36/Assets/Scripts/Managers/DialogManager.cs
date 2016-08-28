using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogManager : MonoBehaviour {

    private struct DialogInfo
    {
        public string actor;
        public string text;
        public float textSpeed;
    }

    private static DialogManager _instance;
    private Queue messageQueue = new Queue();

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

    void Update()
    {
        if( messageQueue.Count > 0)
        {
            DialogBox dialogBox = GameObject.Find("DialogBox").GetComponent<DialogBox>();
            if( !dialogBox.panel.activeSelf)
            {
                dialogBox.panel.SetActive(true);

                DialogInfo dialogInfo = (DialogInfo)messageQueue.Dequeue();
                dialogBox.actor.text = dialogInfo.actor;
                StartCoroutine(TypeText(dialogInfo.text, dialogBox, dialogInfo.textSpeed));
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="actor">The name of the person speaking</param>
    /// <param name="text">What the person speaking is saying</param>
    /// <param name="textspeed">how fast the text goes(lower is faster)</param>
    public void Dialog(string actor, string text, float textspeed)
    {
        DialogInfo dialogInfo = new DialogInfo();
        dialogInfo.actor = actor;
        dialogInfo.text = text;
        dialogInfo.textSpeed = textspeed;

        messageQueue.Enqueue(dialogInfo);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text">What the person speaking is saying</param>
    /// <param name="textspeed">how fast the text goes(lower is faster)</param>
    public void Dialog(string text, float textspeed)
    {
        Dialog("", text, textspeed);
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
