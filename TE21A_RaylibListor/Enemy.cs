using System;
using Raylib_cs;

public class Enemy
{
  public Rectangle rect = new Rectangle(0, 0, 32, 32);
  public Texture2D image = Raylib.LoadTexture("monster.png");
}
