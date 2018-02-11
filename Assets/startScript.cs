using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour {
	
	public GameObject Orb;
	public Rigidbody orbBod;
	
	// Use this for initialization
	void Start ()
	{
		orbBod = Orb.GetComponent<Rigidbody>();
		orbBod.useGravity = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			orbBod.useGravity = true;
		}
	}
}
