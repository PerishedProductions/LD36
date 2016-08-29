using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndPrologue : MonoBehaviour
{
    public void End(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

