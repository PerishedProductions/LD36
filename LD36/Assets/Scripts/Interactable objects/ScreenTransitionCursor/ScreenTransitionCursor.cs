using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public enum SpawnTypes {Left, Middle, Right};

public class ScreenTransitionCursor : Interactable
{
    public string screen;
    public SpawnTypes spawnType = SpawnTypes.Middle;

    private GameObject player;

    public override void Interact()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        switch (spawnType)
        {
            case SpawnTypes.Left:
                player.transform.position = new Vector3(-7, 0, 0);
                break;
            case SpawnTypes.Middle:
                player.transform.position = new Vector3(0, 0, 0);
                break;
            case SpawnTypes.Right:
                player.transform.position = new Vector3(7, 0, 0);
                break;
        }
        SceneManager.LoadScene(screen);
    }
}
