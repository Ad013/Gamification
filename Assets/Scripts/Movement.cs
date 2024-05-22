using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 0f;
	public float rotateSpeed = 0f;

	private Vector3 movement;
	private float rotation;

	void Update ()
	{
		movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
	}

	void FixedUpdate ()
	{
		transform.Translate(movement, Space.Self);
		transform.Rotate(0f, rotation, 0f);
	}
	
}
