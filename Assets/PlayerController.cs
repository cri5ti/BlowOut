using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
//	private CharacterController characterController;
	
	void Start ()
	{
		anim = GetComponentInChildren<Animator>();
//		characterController = GetComponent<CharacterController>();
	}
	
	void Update ()
	{
		var maxSpeed = 3.0f;

		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		transform.localScale = new Vector3(move.x > 0 ? -1 : 1, 1, 1);

		var rb = GetComponent<Rigidbody2D>();
		rb.velocity = move * maxSpeed * Time.deltaTime * 50f;
		
		
//		 transform.position += move * maxSpeed * Time.deltaTime;
//		characterController.Move(move * maxSpeed * Time.deltaTime);

		anim.SetFloat("speed", Math.Abs(move.x));

		anim.SetFloat("upDown", move.y);
	}
}
