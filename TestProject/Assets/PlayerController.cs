using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	private float currentSpeed;
	public float baseSpeed;
	public float crouchSpeed;
	
	public float jumpForce;
	private float moveInput;

	private Rigidbody2D rb;
	


	private bool facingRight = true;

	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;
	
	private bool isCrouching = false;
	private bool isConfined;
	public Transform ceilingCheck;

	private int extraJumps;
	public int extraJumpsValue;
	
	void Start ()
	{
		extraJumps = extraJumpsValue;
		currentSpeed = baseSpeed;
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
	{

		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
		isConfined = Physics2D.OverlapCircle(ceilingCheck.position, checkRadius, whatIsGround);
		
		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * currentSpeed, rb.velocity.y);

		if (facingRight == false && moveInput > 0)
		{
			Flip();
		}
		
		else if (facingRight && moveInput < 0)
		{
			Flip();
		}
	}

	void Update()
	{
		if (isGrounded)
		{
			extraJumps = extraJumpsValue;
			
			if (Input.GetButtonDown("Crouch"))
			{
				isCrouching = true;
				currentSpeed = crouchSpeed;
			}  
			if (Input.GetButtonUp("Crouch"))
			{
				isCrouching = false;
				currentSpeed = baseSpeed;
			}
			
		}


		
		if (Input.GetButtonDown("Jump") && extraJumps > 0 && !isCrouching)
		{
			rb.velocity = Vector2.up * jumpForce;
			extraJumps--;
		}
		
		else if (Input.GetButtonDown("Jump") && extraJumps == 0 && isGrounded)
		{
			rb.velocity = Vector2.up * jumpForce;
		}
		

		
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Coin")
		{
			Destroy(other.gameObject);
		}
	}

}
