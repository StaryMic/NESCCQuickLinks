using Godot;
using System;
using System.Diagnostics;

public partial class AutoURLButton : Button
{
	[Export] private string _url;
	public override void _Ready()
	{
		this.Pressed += OnPressed; // When button is pressed, open URL.
	}

	private void OnPressed()
	{
		Debug.Assert(_url != null, nameof(_url) + " != null");
		OS.ShellOpen(_url);
	}
}
