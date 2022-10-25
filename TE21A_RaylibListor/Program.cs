using Raylib_cs;

Raylib.InitWindow(800, 600, "ListDemo");
Raylib.SetTargetFPS(60);

List<Rectangle> walls = new List<Rectangle>();

walls.Add(new Rectangle(20, 20, 32, 32));
walls.Add(new Rectangle(300, 20, 32, 32));
walls.Add(new Rectangle(700, 20, 32, 32));

List<Enemy> enemies = new List<Enemy>();
enemies.Add(new Enemy());
enemies.Add(new Enemy());
enemies.Add(new Enemy());
enemies[1].rect.y = 200;
enemies[2].rect.y = 400;


Random generator = new Random();
int i = generator.Next(walls.Count);

while (Raylib.WindowShouldClose() == false)
{
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  foreach (Rectangle wall in walls)
  {
    Raylib.DrawRectangleRec(wall, Color.RED);
  }

  foreach ( Enemy e in enemies)
  {
    e.rect.x++;
    Raylib.DrawTexture(e.image, (int)e.rect.x, (int)e.rect.y, Color.WHITE);
  }


  Raylib.EndDrawing();
}