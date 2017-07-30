using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
//	private CharacterController characterController;
	private Rigidbody2D rigidBody;
	
	void Start ()
	{
		anim = GetComponentInChildren<Animator>();
		rigidBody = GetComponent<Rigidbody2D>();
	
//		characterController = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		var maxSpeed = 6.0f;

		var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		input.Normalize();
		
		// flip axis
		transform.localScale = new Vector3(input.x > 0 ? -1 : 1, 1, 1);

		var velocity = input * maxSpeed * Time.deltaTime * 50f;

		rigidBody.velocity = velocity;
		
		anim.SetFloat("leftRight", Math.Abs(velocity.x));
		anim.SetFloat("up", Math.Max(velocity.y, 0));
		anim.SetFloat("down", Math.Max(-velocity.y, 0));
	}
}
