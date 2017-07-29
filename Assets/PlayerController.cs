using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Animator anim;
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	void Update ()
	{
		var maxSpeed = 3.0f;

		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		transform.localScale = new Vector3(move.x > 0 ? -1 : 1, 1, 1);
		
		transform.position += move * maxSpeed * Time.deltaTime;

		anim.SetFloat("speed", Math.Abs(move.x));

		anim.SetFloat("upDown", move.y);
	}
}
