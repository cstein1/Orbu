using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseController : MonoBehaviour {

    public enum Phase
    {
        Select, Zip, Queue, Execution, End
    };

    bool setup;
    public Phase phase;
    public GameObject zipper;

	// Use this for initialization
	void Start () {
        setup = true;
        phase = Phase.Select;
	}
	
	// Update is called once per frame
	void Update () {
        // change through the phases, but they have their own controllers
        if (setup)
        {
            switch (phase)
            {
                case Phase.Select:
                    SelectPhaseSetup();
                    Debug.Log("Setup");
                    break;
            }
        } else
        {

        }
	}

    public void SelectPhaseSetup()
    {
        GameObject board = GameObject.Find("Board");
        zipper = Instantiate(zipper);
        zipper.transform.SetParent(board.transform);
        zipper.name = "Zipper";

        setup = false;
    }

    public void SelectPhase()
    {

    }
}
