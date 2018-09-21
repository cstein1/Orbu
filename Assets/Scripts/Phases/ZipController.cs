using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZipController : MonoBehaviour {

    public GameObject Box1; // You're welcome future me. Deal with it. Abstract that.

	// Use this for initialization
	void Start () {
        Box1 = Instantiate(Box1);
        Box1.name = "Box1";
        Box1.transform.SetParent(this.transform);
        Box1.transform.position = new Vector3(3, 0, GameObject.Find("Hand").transform.position.z);
        Box1.transform.localScale = new Vector3(2, 3, 3);

        Box1 = Instantiate(Box1);
        Box1.name = "Box2";
        Box1.transform.SetParent(this.transform);
        Box1.transform.position = new Vector3(0, 0, -.5f);
        Box1.transform.localScale = new Vector3(2, 3, 3);

        Box1 = Instantiate(Box1);
        Box1.name = "Box3";
        Box1.transform.SetParent(this.transform);
        Box1.transform.position = new Vector3(-3, 0, -.5f);
        Box1.transform.localScale = new Vector3(2, 3, 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
