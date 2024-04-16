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
Inventory inventory = new Inventory();


int windowWidth = 1280;
int windowHeight = 800;
int fps = 60;

Raylib.InitWindow(windowWidth, windowHeight, "Clickyballs");
Raylib.SetTargetFPS(fps);



Music music = Raylib.LoadMusicStream("Neverseemeagain.mp3");


String scene = "shop";

Raylib.InitAudioDevice();

Raylib.PlayMusicStream(music);

rewards.BuffsAdd();
rewards.LoadCharacters();


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
        Inventory inventory1 = new();


        //system
        ui.Draw();
        enemy.Draw();

        damage1.Hit();

        inventory1.InventoryLogic();

        rewards1.Upgradebuttons();




        //graphics


        damage.Draw();
        rewards.start();
        inventory.DrawInventoryButton();
        store.Drawstorebutton();
        ui.DrawLines();

        store1.Button();



        //Store
        if (Inventory.InventoryButtonispressed == true)
        {

            scene = "inventory";

        }

        if (Store.storebuttonispressed == true)
        {

            scene = "shop";

        }

    }
    else if (scene == "shop")
    {

        Store store1 = new();
        Rewards rewards1 = new();


        store.Draw();

        store.Drawbackbutton();
        store.DrawBuybutton();
        store.postitionDraw();


        rewards.Shoplogic();
        store.DrawCharacters();


        store1.Button();
        if(Inventory.rewardClaimed == false)
        {
            scene = "rewardcut";
        }

        if (Store.backbuttonispressed == true)
        {

            scene = "game";

        }


    }
    else if (scene == "rewardcut")
    {
        
        Raylib.ClearBackground(Color.Purple);

        Store store1 = new();


        store1.Button();

        while(Inventory.rewardClaimed == false)
        {
            Inventory.Update();

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
                {
                        Inventory.rewardClaimed = true;
                }
        }

    }
    else if (scene == "inventory")
    {
        Inventory inventory1 = new();

        inventory.DrawInventory();
        inventory.DrawInvbackbutton();

        inventory1.InventoryLogic();

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
