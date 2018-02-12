using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSwing : MonoBehaviour
{

	public GameObject Hammer;
	public Rigidbody ham;
	
	// Use this for initialization
	void Start ()
	{
		ham = Hammer.GetComponent<Rigidbody>();
		ham.useGravity = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	private void OnTriggerEnter(Collider other)
	{
		//start swinging when domino hits button
		if (other.gameObject.tag == "Domino")
		{
			ham.useGravity = true;
		}

	}
}
