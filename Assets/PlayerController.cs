using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
//	private CharacterController characterController;
	private Rigidbody2D rigidBody;
	
	public float Energy { get; private set; }
	
	void Start ()
	{
		Energy = 1;
		anim = GetComponentInChildren<Animator>();
		rigidBody = GetComponent<Rigidbody2D>();
	
//		characterController = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		Energy = Math.Max(Energy - Time.deltaTime * 0.025f, 0);
		
		var maxSpeed = 6.0f;

		var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		input.Normalize();
		
		// flip axis

		transform.localScale = new Vector3(input.x > 0 ? -1 : 1, 1, 1);

		
		anim.speed = Math.Max(0.2f, Energy);
		var velocity = input * maxSpeed * Time.deltaTime * Math.Max(15f, 50f * Energy);

		rigidBody.velocity = velocity;
		
		anim.SetFloat("leftRight", Math.Abs(velocity.x));
		anim.SetFloat("up", Math.Max(velocity.y, 0));
		anim.SetFloat("down", Math.Max(-velocity.y, 0));
	}

	public void DrinkUp()
	{
		// Energy = (float)Math.Ceiling(Energy * 4f) * 0.25f;
		Energy = 1;
	}
}
