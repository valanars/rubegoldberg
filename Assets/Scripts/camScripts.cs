using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScripts : MonoBehaviour
{

	public Camera firstCam;

	public Camera secondCam;

	public float minX;
	public float maxX;

	public float moveSpeed;
	public bool move;
	
	// Use this for initialization
	void Start ()
	{
		move = false;
		firstCam.enabled = true;
		
		secondCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		// move script activates when space key is pressed
		if (Input.GetKey(KeyCode.Space))
		{
			move = true;
		}
		if (move == true)
		{
			Vector3 currentPos = transform.position;

			currentPos.x += moveSpeed * Time.deltaTime;
			if (currentPos.x > maxX)
			{
				currentPos.x = maxX;
				moveSpeed = -moveSpeed;
			} else if (currentPos.x <= minX)
			{
				firstCam.enabled = false; //switch cameras!
				secondCam.enabled = true;
			}

			transform.position = currentPos;
		}
	}
}
