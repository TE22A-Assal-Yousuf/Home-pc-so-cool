global using Raylib_cs;
using System.Formats.Asn1;
using System.Numerics;
using System.Runtime.InteropServices;

UI ui = new UI();
Store store = new Store();
Enemy enemy = new Enemy();
Player player = new Player();
Damage damage = new Damage();
Rewards rewards = new Rewards();


int windowWidth = 1280;
int windowHeight = 800;
int fps = 60;

Raylib.InitWindow(windowWidth, windowHeight, "Clickyballs");
Raylib.SetTargetFPS(fps);



Music music = Raylib.LoadMusicStream("Neverseemeagain.mp3");


String scene = "game";

Raylib.InitAudioDevice();

Raylib.PlayMusicStream(music);

while (!Raylib.WindowShouldClose())
{
        damage.update();

    Raylib.UpdateMusicStream(music);

    if (Raylib.IsKeyPressed(KeyboardKey.P))
    {
        Raylib.StopMusicStream(music);
        Raylib.PlayMusicStream(music);

    }


    Raylib.BeginDrawing();




    if (scene == "start")
    {

        Raylib.ClearBackground(Color.Purple);

        if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                scene = "game";
            }

    }

    else if (scene == "game")
    {
        Store store1 = new();
        Damage damage1 = new();
        Rewards rewards1 = new();


        //system
        ui.Draw();
        enemy.Draw();

        store1.Button();
        damage1.Hit();

        rewards1.Upgradebuttons();
        rewards.BuffsAdd();
        
        //graphics


        damage.Draw();
        rewards.start();
        store.Drawstorebutton();
        ui.DrawLines();


        //Store
        if (Store.storebuttonispressed == true)
        {

            scene = "shop";

        }

    }
    else if (scene == "shop")
    {
        
        Store store1 = new();
        store.Draw();

        store.Drawbackbutton();
        store.DrawBuybutton();
        store.postitionDraw();

        

        rewards.DrawCharacters();

        store1.Button();

        if (Store.backbuttonispressed == true)
            {

                scene = "game";

            }


    }

    Raylib.EndDrawing();
}


Raylib.UnloadMusicStream(music);

Raylib.CloseAudioDevice();

Raylib.CloseWindow();
