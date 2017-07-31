using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("OnTriggerEnter2D!");
		
		var player = other.GetComponent<PlayerController>();
		if (player)
		{
			player.DrinkUp();
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("OnTriggerExit2D!");
	}
}
