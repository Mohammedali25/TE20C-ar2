using System;
using Raylib_cs;


{
    // Starta grafikmotorn
    Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

    // Bestäm skärmuppdatering
    Raylib.SetTargetFPS(60);

    // Ladda in bilden
    Texture2D månenLitenTexture = Raylib.LoadTexture(@"./Resurser/uploads_kim_jong_un_png18 (2).png");
Texture2D månenStorTexture = Raylib.LoadTexture(@"./Resurser/uploads_kim_jong_un_png18 (2).png");
    // Animationsloopen
    while (!Raylib.WindowShouldClose())
    {
        // Börja rita
        Raylib.BeginDrawing();

        // Töm ritytan
        Raylib.ClearBackground(Color.DARKBLUE);

        // Rita ut bilder
        Raylib.DrawTexture(månenLitenTexture, 100, 100, Color.WHITE);
        Raylib.DrawTexture(månenStorTexture, 300, 100, Color.WHITE);
      
        

        // Ritat ut på fönstret
        Raylib.EndDrawing();



        
    }
}