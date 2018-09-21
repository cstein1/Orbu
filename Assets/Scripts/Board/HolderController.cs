using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Card" && transform.childCount == 0)
        {
            other.gameObject.GetComponent<CardController>().cardHolding = false;
            other.gameObject.transform.parent = this.transform;
            other.gameObject.transform.position = this.transform.position;
        }
    }
}
