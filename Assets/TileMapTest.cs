using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapTest : MonoBehaviour
{
	public GameObject player;	
	public Tilemap map;
	
	// Use this for initialization
	void Start ()
	{
		map = GetComponent<Tilemap>();
	}
	
	// Update is called once per frame
	void Update () {	
		 var tilePos = map.WorldToCell(player.transform.position);

		var tran = map.GetTransformMatrix(tilePos);
		tran.m33 = -1f;
		map.SetTransformMatrix(tilePos, tran);
	}
}
