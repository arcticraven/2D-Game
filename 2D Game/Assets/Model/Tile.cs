using UnityEngine;
using System.Collections;
using System;

public class Tile{

	public enum TileType {Dirt, Water};

	Action<Tile> cbTileTypeChanged;

	TileType type = TileType.Dirt;

	LooseObjects looseObject;
	InstalledObject installedObject;

	World world;

	int x;
	int y;


	public Tile(World world, int x, int y){
		this.world = world;
		this.x = x;
		this.y = y;
	
	}

	public void RegisterTileTypeChangedCB(Action<Tile> callback){
		cbTileTypeChanged += callback;
	}

	public void UnregisterTileTypeChangedCB(Action<Tile> callback){
		cbTileTypeChanged -= callback;
	}


	//Getters and Setters
	public int X{
		get { 
			return x;
		}
	}

	public int Y {
		get { 
			return y;
		}
	}

	public TileType Type{
		get{ 
			return type;
		}
		set{
			TileType oldType = type;
			int firstRender = 1;
			type = value;
			//Call the callback
			if((cbTileTypeChanged != null && oldType != type) || firstRender == 1)
				cbTileTypeChanged(this);

			firstRender = 0;
		}
	}


}
