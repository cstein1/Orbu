using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

    public GameObject card;

	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            Cast();
    }

    public void Cast()
    {
        try
        {
            transform.GetChild(0).GetComponent<CardController>().MoveCard("space");
        }
        catch
        {
            Debug.Log("Hand Controller, Cast(): Not enough cards in hand (hopefully)");
        }
    }
}
