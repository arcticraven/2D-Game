using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public GameObject Cursor;

	Vector3 lastFramePosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 currFramePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		currFramePosition.z = 0;

		//Update Cursor Position
		Cursor.transform.position = currFramePosition;

		Tile tileUnderMouse = GetTileAtWorldCord (currFramePosition);

		//Start Drag
		if(Input.GetMouseButtonDown(0){
			break;

		}

		//End Drag
		if (Input.GetMouseButtonUp (0)) {
			if (tileUnderMouse != null) {
				if (tileUnderMouse.Type == Tile.TileType.Dirt)
					tileUnderMouse.Type = Tile.TileType.Water;
				else
					tileUnderMouse.Type = Tile.TileType.Dirt;
			
			}
		
		}

		//Right or Middle Mouse Button scren drag
		if(Input.GetMouseButton(1) || Input.GetMouseButton(2)){

			Vector3 diff = lastFramePosition - currFramePosition;
			Camera.main.transform.Translate (diff);
		} 


		lastFramePosition =  Camera.main.ScreenToWorldPoint (Input.mousePosition);
		lastFramePosition.z = 0;
	}

	Tile GetTileAtWorldCord(Vector3 cord){
<<<<<<< HEAD
		int x = Mathf.FloorToInt (cord.x + 0.5f);
		int y = Mathf.FloorToInt (cord.y + 0.5f);
		
		return WorldController.Instance.world.getTileAt(x, y);
	}

=======
		int x = Mathf.FloorToInt(cord.x);
		int y = Mathf.FloorToInt(cord.y);



		return World.GetTileAt (x, y);
	}
>>>>>>> origin/master
}
