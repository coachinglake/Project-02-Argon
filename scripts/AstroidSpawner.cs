using Godot;
using System;

public partial class AstroidSpawner : Node3D
{
	private PackedScene astriod;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		astriod = (PackedScene)GD.Load("res://prefabs/mainmenu_astriod.tscn");
		
		Node meteor = astriod.Instantiate();
		
		AddChild(meteor);
	}
}
