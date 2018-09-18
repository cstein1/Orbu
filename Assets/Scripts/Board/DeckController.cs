using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour {

    public GameObject card;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 30; i++)
        {
            Vector3 v = new Vector3(transform.position.x, transform.position.y, -1);
            GameObject n = Instantiate(card, v, Quaternion.identity);
            n.transform.parent = this.transform;
            n.name = i.ToString();
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d"))
            Draw();
    }

    public void Draw() // WORKS
    {
        try
        {
            transform.GetChild(0).GetComponent<CardController>().MoveCard("d");
        }
        catch
        {
            Debug.Log("DeckController, Draw(): Could not draw any more");
        }
        
    }
}
