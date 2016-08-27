using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 10;
    public Vector3 target;

    public bool walking = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Click();
        }

        if (walking)
        {
            float step = speed * Time.deltaTime;
            if (this.transform.position.x != target.x)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector2(target.x, this.transform.position.y), step);
            }
            else
            {
                walking = false;
            }
        }

	}

    void Click()
    {
        int layerMask = 1 << 8;
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 10000f, layerMask);
        if (hit)
        {
            Debug.Log(hit.transform.tag);
            target = hit.transform.position;
            walking = true;
        }
    }
}
