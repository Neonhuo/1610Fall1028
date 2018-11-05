using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
	private Rigidbody2D rb;

	public float jumpForce;
	public float speed;
	private float moveInput;

	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		
		moveInput = Input.GetAxis("Horizontal");
		Debug.Log(moveInput);
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
	}
}
