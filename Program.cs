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


String scene = "start";

Raylib.InitAudioDevice();

Raylib.PlayMusicStream(music);

rewards.BuffsAdd();
rewards.LoadCharacters();
inventory.LoadInventory();


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

        Raylib.ClearBackground(Color.Blue);

        Raylib.DrawText("press space to start", 200, 400 ,40, Color.Black);

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
        if (Inventory.inventoryButtonispressed == true)
        {

            scene = "inventory";

        }

        if (Store.storeButtonIsPressed == true)
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


        store.DrawCharacters();


        store1.Button();
        if (Inventory.rewardClaimed == false)
        {
            scene = "rewardcut";

            
        }

        if (Store.backButtonIsPressed == true)
        {

            scene = "game";

        }


    }
    else if (scene == "rewardcut")
    {

        Raylib.ClearBackground(Color.Blank);

        Store store1 = new();
        Inventory inventory1 =new();


        Inventory.DrawReward();
        inventory.DrawRollAgainButton();


        inventory1.DrawInvbackbutton();
        inventory1.InventoryLogic();
                




        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            Inventory.rewardClaimed = true;
        }

        if (Store.backButtonIsPressed == true)
        {
            Inventory.rewardClaimed = true;
            scene = "game";

        }

        if (Inventory.rollAgainButtonIsPressed == true)
        {
            Inventory.rewardClaimed = false;

            Inventory.rollAgainButtonIsPressed = false;

        }
        else
        {
            Inventory.rewardClaimed = true;
        }
    }
    else if (scene == "inventory")
    {
        Inventory inventory1 = new();

        inventory.DrawInventory();
        inventory.DrawInvbackbutton();

        inventory1.InventoryLogic();

        if (Store.backButtonIsPressed == true)
        {

            scene = "game";

        }
    }

    Raylib.EndDrawing();
}


Raylib.UnloadMusicStream(music);

Raylib.CloseAudioDevice();

Raylib.CloseWindow();
