using Godot;
using System;

public partial class MainmenuAstriod : RigidBody3D
{
	Vector3 LocalForce = new Vector3(30, 0, 0); // Force in the X direction
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector3 globalForce = GlobalTransform.Basis * LocalForce;
		ApplyCentralForce(globalForce);
	}
	
	public void _on_timer_timeout()
	{
		 QueueFree();
	}
	
	
}
