using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;

    public static GameManager Instance
    {

        get
        {
            if (_instance == null)
            {
                GameObject go = (GameObject)Instantiate(Resources.Load("GameManager"));
                _instance = go.GetComponent<GameManager>();
            }

            return _instance;
        }

    }

    public GameObject playerPrefab;

    private GameObject player;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        _instance = this;
    }

    public PlayerController GetPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Instantiate(playerPrefab);
        }
        return player.GetComponent<PlayerController>();
    }

    public ActionMenu GetActionMenu()
    {
        return GameObject.Find("ActionBox").GetComponent<ActionMenu>();
    }

    public UIManager GetUI()
    {
        return UIManager.Instance;
    }

    public Inventory GetInventory()
    {
        return GameObject.Find("Inventory").GetComponent<Inventory>();
    }
}
