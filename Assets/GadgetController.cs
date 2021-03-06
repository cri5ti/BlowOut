﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GadgetController : MonoBehaviour
{
	private Animator _animator;
	
	// Use this for initialization
	void Start ()
	{
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private bool isOn;

	public void StartUse()
	{
		if (isOn) return;
		isOn = true;
		_animator.SetTrigger("on");		
	}

	public void StopUse()
	{
		if (!isOn) return;
		isOn = false;
		_animator.SetTrigger("off");
	}
}
