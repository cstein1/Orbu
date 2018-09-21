using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO Fan out cards
//TODO Draw animation
//TODO Sprite assignment

public class CardController : MonoBehaviour {

    public enum props
    {
        Charm, Bang, Trap, Potion, Color
    };
    
    public enum keywords
    {
        Conjure, Drain
    };

    public bool cardHolding;

    // Use this for initialization
    void Start () {
        // Bunch of cases for etb
        //rb = gameObject.GetComponent<Rigidbody2D>();
        cardHolding = false;
    }

    // Update is called once per frame
    void Update () {
        if (cardHolding)
        {
            transform.position = new Vector3(
                    Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
                    transform.position.z
                );

        }
    }

    void OnMouseDown()
    {
        cardHolding = true;
    }

    void OnMouseUp()
    {
        cardHolding = false;
    }

    public void MoveCard(string key)
    {
        try
        {
            switch (key)
            {
                case "space":
                    transform.parent = transform.parent.parent.Find("Mat");
                    transform.position = transform.parent.position;
                    transform.position = new Vector3(
                        transform.parent.childCount,
                        transform.position.y, -1);
                    break;
                case "d":
                    transform.parent = transform.parent.parent.Find("Hand");
                    transform.position = transform.parent.position;
                    transform.position = new Vector3(
                        transform.parent.childCount,
                        transform.position.y, -1);
                    break;
                case "g":
                    transform.parent = transform.parent.parent.Find("Graveyard");
                    transform.position = transform.parent.position;
                    break;
            }
            
        }
        catch
        {
            Debug.Log("Card Controller: Not enough cards in hand/deck/gyard");
        }
    }
}
