using Godot;
using System;

public partial class AstroidSpawner : Node3D
{
	private PackedScene astriod;
	private PackedScene astriod2;
	private bool rock = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		astriod = (PackedScene)GD.Load("res://prefabs/mainmenu_astriod.tscn");
		astriod2 = (PackedScene)GD.Load("res://prefabs/mainmenu_astriod2.tscn");
		Node meteor = astriod.Instantiate();
		Node meteor2 = astriod.Instantiate();
		
		if(rock == true)
		{
			AddChild(meteor);
			rock = false;
		}else{
			AddChild(meteor2);
			rock = true;
		}
		
	}
}
