using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Perry Williams
public class CharacterMover : MonoBehaviour
{

	private CharacterController controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f;
	public float RotateSpeed = 3.0f;
	
	private Vector3 position;
	private Vector3 rotation;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.isGrounded)
		{
			position.Set(0, 0, MoveSpeed*Input.GetAxis("Vertical"));
			rotation.Set(0, RotateSpeed*Input.GetAxis("Horizontal"), 0);
			transform.Rotate(rotation);
			position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}
		
		position.y -= Gravity*Time.deltaTime;
		controller.Move(position*Time.deltaTime);
	}
}
