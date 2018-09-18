using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseController : MonoBehaviour {

    public enum phases
    {
        Select, Zip, Queue, Execution, End
    };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// change through the phases, but they have their own controllers
	}
}
