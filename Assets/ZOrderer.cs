using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZOrderer : MonoBehaviour {
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		sr.sortingOrder = -(int)(transform.position.y * 100f);
	}
}
