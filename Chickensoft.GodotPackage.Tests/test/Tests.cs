namespace Chickensoft.GodotPackage.Tests;

using System.Reflection;
using Godot;
using Chickensoft.GoDotTest;

public partial class Tests : Node2D {
  public override void _Ready()
    => _ = GoTest.RunTests(Assembly.GetExecutingAssembly(), this);
}
