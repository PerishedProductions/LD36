using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public enum SpawnTypes {Left, Middle, Right};

public class ScreenTransitionCursor : Interactable
{
    public string screen;
    public Vector3 appearPoint;
    public Vector3 newCamPosition;

    private GameObject player;

    public override void Interact()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = appearPoint;
        Camera.main.transform.position = newCamPosition;
    }
}
