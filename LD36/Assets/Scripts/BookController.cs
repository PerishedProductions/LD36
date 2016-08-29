using UnityEngine;
using System.Collections;

public class BookController : MonoBehaviour {

    public GameObject page1;
    public GameObject page2;
    public GameObject page3;

    private int index = 0;

    void UpdatePage()
    {
        switch (index)
        {
            case 0:
                page1.SetActive(true);
                page2.SetActive(false);
                page3.SetActive(false);
                break;
            case 1:
                page1.SetActive(false);
                page2.SetActive(true);
                page3.SetActive(false);
                break;
            case 2:
                page1.SetActive(false);
                page2.SetActive(false);
                page3.SetActive(true);
                break;
        }
    }

    public void UpIndex()
    {
        if (index != 2)
        {
            index++;
            UpdatePage();
        }
    }

    public void DownIndex()
    {
        if (index != 0)
        {
            index--;
            UpdatePage();
        }
    }

    public void CloseBook()
    {
        GameObject tablet = GameObject.Find("CodeTablet").transform.GetChild(0).gameObject;
        if (tablet.activeSelf)
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
            tablet.SetActive(false);
        }
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
