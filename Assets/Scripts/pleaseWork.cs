using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class pleaseWork : MonoBehaviour {

	public Text text;

	public Rigidbody r;

	// Use this for initialization
	void Start()
	{
		r = GetComponent<Rigidbody>();
		r.isKinematic = false;

		text.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		//start swinging when domino hits button
		if (other.gameObject.tag == "End")
		{
			r.useGravity = false;
			r.isKinematic = true;

			text.enabled = true;
			text.text = "the end!";
		}
	}
}
