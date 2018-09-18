using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour {

    public enum props
    {
        Charm, Bang, Trap, Potion, Color
    };
    
    public enum keywords
    {
        Conjure, Drain
    };

    bool follow;

    // Use this for initialization
    void Start () {
        // Bunch of cases for etb
        //rb = gameObject.GetComponent<Rigidbody2D>();
        follow = false;
    }

    // Update is called once per frame
    void Update () {
        // Is card hovered over
        if (follow)
        {
            //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        /*if (Input.GetKeyDown("space"))
            MoveCard("space");
        else if (Input.GetKeyDown("d"))
            MoveCard("d");
        else if (Input.GetKeyDown("g"))
            MoveCard("g");*/
    }

    void OnMouseDown()
    {
        follow = !follow;
        Debug.Log("Click heard!");
    }

    public void MoveCard(string key)
    {
        try
        {
            switch (key)
            {
                case "space":
                    transform.parent = transform.parent.parent.Find("Mat");
                    break;
                case "d":
                    transform.parent = transform.parent.parent.Find("Hand");
                    break;
                case "g":
                    transform.parent = transform.parent.parent.Find("Graveyard");
                    break;
            }
            transform.position = transform.parent.position;
        }
        catch
        {
            Debug.Log("Card Controller: Not enough cards in hand/deck/gyard");
        }
    }
}
