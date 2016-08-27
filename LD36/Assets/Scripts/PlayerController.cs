using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    public float speed = 10;
    public Interactable interactable;
    private List<Item> items = new List<Item>();
    public bool walking = false;
    private Animator anim;

    private bool faceRight = true;


    // Use this for initialization
    void Awake () {
        DontDestroyOnLoad(this);
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Click();
        }

        anim.SetBool("walking", walking);

        if (walking)
        {
            float step = speed * Time.deltaTime;
            if (this.transform.position.x != interactable.transform.position.x)
            {
                if (interactable.transform.position.x > this.transform.position.x && !faceRight)
                {
                    Flip();
                }
                else if (interactable.transform.position.x < this.transform.position.x && faceRight)
                {
                    Flip();
                }

                this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector2(interactable.transform.position.x, this.transform.position.y), step);
            }
            else
            {
                interactable.Interact();
                walking = false;
            }
        }

	}

    void Flip()
    {
        faceRight = !faceRight;
        Vector3 theScale = transform.localScale;

        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void Click()
    {
        int layerMask = 1 << 8;
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y), Vector2.zero, 10000f, layerMask);
        if (hit)
        {
            Debug.Log(hit.transform.tag);
            interactable = hit.transform.root.GetComponent<Interactable>();
            walking = true;
        }
    }

    public void AddItem( Item item )
    {
        Debug.Log("Added item: " + item.name);
    }
}
