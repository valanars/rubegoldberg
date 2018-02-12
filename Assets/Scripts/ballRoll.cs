using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballRoll : MonoBehaviour
{

	public GameObject FinalBall;
	public Rigidbody ball;

	// Use this for initialization
	void Start()
	{
		ball = FinalBall.GetComponent<Rigidbody>();
		ball.useGravity = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		//start swinging when domino hits button
		if (other.gameObject.tag == "Seesaw")
		{
			ball.useGravity = true;
		}
	}
}
