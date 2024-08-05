using Godot;
using System;

public partial class GameStart : MarginContainer
{

	public void _on_new_game_gui_input(InputEvent @event)
	{
		if (@event.IsActionPressed("ui_mouse_left"))
		{
			GD.Print($"Left button was clicked at {(@event as InputEventMouseButton).Position}");
			this.GetTree().ChangeSceneToFile("res://scenes/GUI.tscn");
		}
	}
	

	public void _on_continue_gui_input(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent && mouseEvent.Pressed)
		{
			switch (mouseEvent.ButtonIndex)
			{
				case MouseButton.Left:
					GD.Print($"Left button was clicked at {mouseEvent.Position}");
					this.GetTree().ChangeSceneToFile("res://scenes/GUI.tscn");
					break;
				case MouseButton.WheelUp:
					GD.Print("Wheel up");
					break;
			}
		}
	}
	
}
