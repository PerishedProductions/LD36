using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScreenTransitionCursor : Interactable
{
    public string screen;

    public override void Interact()
    {
        SceneManager.LoadScene(screen);
    }
}
