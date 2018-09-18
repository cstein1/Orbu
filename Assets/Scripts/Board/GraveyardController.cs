using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardController : MonoBehaviour {

    List<GameObject> cards;

    // Use this for initialization
    void Start () {
        cards = new List<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addCard(GameObject card)
    {
        cards.Add(card);
    }
}
