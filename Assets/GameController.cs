using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public RectTransform EnergyFill;

	public PlayerController Player;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		EnergyFill.sizeDelta = new Vector2(256f * Player.Energy, EnergyFill.sizeDelta.y);
	}
}
