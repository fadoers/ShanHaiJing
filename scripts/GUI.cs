using Godot;
using System;

public partial class GUI : MarginContainer
{
	private Label _numberLabel;
	private TextureProgressBar _bar;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
		 _bar = (TextureProgressBar) GetNode("Bars/LifeBar/Gauge");
		_numberLabel = (Label) GetNode("Bars/LifeBar/Count/Background/Number");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
