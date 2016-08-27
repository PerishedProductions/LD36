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

    public void GetPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Instantiate(playerPrefab);
        }
    }
}
