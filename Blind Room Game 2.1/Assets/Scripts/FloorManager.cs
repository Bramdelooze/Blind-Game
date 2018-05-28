using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour {

	[SerializeField]
	private GameObject tile;

	[SerializeField]
	private int xValue, zValue;

	// List of all tiles
	private List<GameObject> allTiles = new List<GameObject>();

	void Start () {

		CreateFloor();
		
	}

	void Update () {
		
	}

	private void CreateFloor () {

		float tileSize = tile.GetComponent<Renderer>().bounds.size.x;

		// Loop through lengths and instantiate surface
		for (int x = 0; x < xValue; x++)
		{
			for (int z = 0; z < zValue; z++)
			{
				GameObject newTile = Instantiate(tile);

				// Add to list of all tiles
				allTiles.Add(newTile);
				newTile.transform.position = new Vector3(tileSize * x, 0, tileSize * z);
			}
		}
	}

	private void CreateWall() {


	
	}
}
