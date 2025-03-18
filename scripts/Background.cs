using Godot;
using System;

public partial class Background : MeshInstance3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	 public float RotationSpeed = 10f; // Degrees per second
	
	public override void _Process(double delta)
	{
		// Convert the speed from degrees to radians (Godot uses radians)
 		float radians = Mathf.DegToRad((float)delta * RotationSpeed);
 		Rotate(Vector3.Up, radians); 
	}
}
