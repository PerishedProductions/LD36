using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour {

    public GameObject credits;

    void Start()
    {
        GameManager.Instance.StartBgMusic();
    }

	public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void ToogleCredits()
    {
        credits.SetActive(!credits.activeSelf);
    }
}
