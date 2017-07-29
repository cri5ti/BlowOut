using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start () {
		
	}
	
	void Update ()
	{
		var speed = 2.0f;

		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

		transform.localScale = new Vector3(move.x > 0 ? -1 : 1, 1, 1);
		
		transform.position += move * speed * Time.deltaTime;
		
//		var pos = transform.position;
//		pos.x += move;
//		transform.position = pos;
		//var rb = GetComponent<Rigidbody2D>();
		// rb.velocity = new Vector2(move * 5f, rb.velocity.y);
	}
}
