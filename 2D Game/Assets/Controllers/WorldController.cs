using UnityEngine;
using System.Collections;


public class WorldController : MonoBehaviour {

<<<<<<< HEAD

	public static WorldController Instance{ get; protected set;}
=======
	static WorldController _instance;

	public static WorldController Instance { get; protected set;}
>>>>>>> origin/master

	public Sprite dirtSprite;
	public Sprite waterSprite;


<<<<<<< HEAD
	public World world{ get; protected set;}
	// Use this for initialization
	void Start () {
		world = new World();
		Instance = this;
=======
	public World world { get; protected set;}
	// Use this for initialization
	void Start () {
		world = new World();
		_instance = this;
>>>>>>> origin/master

		//Create game object for each tile
		for (int x = 0; x < world.Width; x++) {
			for (int y = 0; y < world.Height; y++) {
				GameObject tile_go = new GameObject ();
				Tile tile_data = world.getTileAt (x, y);


				tile_go.name = "Tile_" + x + "_" + y;
				tile_go.transform.position = new Vector3 (tile_data.X, tile_data.Y, 0);
				tile_go.transform.SetParent (this.transform, true);

				tile_go.AddComponent<SpriteRenderer> ();

				tile_data.RegisterTileTypeChangedCB ( (tile) => { onTileTypeChanged(tile, tile_go);});
			}
		}

		world.RandomizeTiles();
	}//End of Start

	void onTileTypeChanged(Tile tile_data, GameObject tile_go){

		if (tile_data.Type == Tile.TileType.Dirt)
			tile_go.GetComponent<SpriteRenderer> ().sprite = dirtSprite;
		else if (tile_data.Type == Tile.TileType.Water)
			tile_go.GetComponent<SpriteRenderer> ().sprite = waterSprite;
		else
			Debug.LogError ("OnTileTypeChanged - Unrecognized tile Type");
				
		
	}

	float randomizeTileTimer = 2f;
	// Update is called once per frame
	void Update () {
		
	}
}
