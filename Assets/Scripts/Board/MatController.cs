using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatController : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("g"))
            Kill();
    }

    public void Kill()
    {
        try
        {
            transform.GetChild(0).GetComponent<CardController>().MoveCard("g");
        }
        catch
        {
            Debug.Log("MatController, Kill(): No creatures on board");
        }
    }
}
