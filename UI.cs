using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class UI
{

        Sound bgmusic = Raylib.LoadSound("Neverseemeagain.mp3");
        public static Texture2D GameBackground = Raylib.LoadTexture(@"Gamebackground.png");

        public void DrawLines()
        {
                Raylib.DrawLine(10, 0, 10, 800, Color.Red);//side 1
                Raylib.DrawLine(460, 0, 460, 800, Color.Red);//side 2
                Raylib.DrawLine(1270, 0, 1270, 800, Color.Red);//down 2
                Raylib.DrawLine(870, 0, 870, 800, Color.Red);//down 1
        }
        public void Draw()
        {
                Raylib.DrawTexture(GameBackground, 0, 0, Color.White);


                Raylib.DrawTextEx(Damage.MinecrafterFont, "Points:", new Vector2(575, 230), 40, 5, Color.White);
                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.points}", new Vector2(520, 270), 50, 5, Color.White);

                //Raylib.DrawTextEx(Damage.MinecraftFont, $"{Rewards.ShopResetTimer}", new Vector2(100, 70), 50, 5, Color.White);

                Raylib.DrawTextEx(Damage.MinecrafterFont, $"DPS {Player.autoDamage}", new Vector2(930, 50), 20, 5, Color.White);

                Raylib.DrawTextEx(Damage.MinecraftFont, $"Gems: {Damage.gems}", new Vector2(925, 105), 50, 5, Color.White);

                //hit cooldown bar
                if (Player.autoDamage >= 1)
                {

                        Raylib.DrawRectangle(930, 75, 70, 10, Color.Gray);
                        Raylib.DrawRectangle(930, 75, (int)(Damage.autodamagedelay * 70), 10, Color.White);

                }





                /* Raylib.DrawRectangle(0, 0, 1280, 32, Color.DarkBrown);//top
                 Raylib.DrawRectangle(0, 768, 1280, 32, Color.DarkBrown);//bottom
                 Raylib.DrawRectangle(0, 0, 32, 800, Color.DarkBrown);//left
                 Raylib.DrawRectangle(800, 0, 800, 800, Color.DarkBrown);//right

                 //448 , 736*/

        }

}
public class Store
{

        //postition 
        public static List<Rectangle> PositionsList = new List<Rectangle>();


        public static Rectangle Position1 = new Rectangle(new Vector2(78, 128), new Vector2(250, 250));
        public static Rectangle Position2 = new Rectangle(new Vector2(360, 128), new Vector2(250, 250));
        public static Rectangle Position3 = new Rectangle(new Vector2(642, 128), new Vector2(250, 250));
        public static Rectangle Position4 = new Rectangle(new Vector2(78, 420), new Vector2(250, 250));
        public static Rectangle Position5 = new Rectangle(new Vector2(360, 420), new Vector2(250, 250));
        public static Rectangle Position6 = new Rectangle(new Vector2(642, 420), new Vector2(250, 250));
        public static Rectangle SpecialPosition = new Rectangle(new Vector2(924, 128), new Vector2(250, 550));

        public void postitionDraw()
        {
                PositionsList.Add(Position1);
                PositionsList.Add(Position2);
                PositionsList.Add(Position3);
                PositionsList.Add(Position4);
                PositionsList.Add(Position5);
                PositionsList.Add(Position6);
                PositionsList.Add(SpecialPosition);

                Raylib.DrawRectangleRec(Position1, Color.Black);
                Raylib.DrawRectangleRec(Position2, Color.Black);
                Raylib.DrawRectangleRec(Position3, Color.Black);
                Raylib.DrawRectangleRec(Position4, Color.Black);
                Raylib.DrawRectangleRec(Position5, Color.Black);
                Raylib.DrawRectangleRec(Position6, Color.Black);
                Raylib.DrawRectangleRec(SpecialPosition, Color.Black);


        }
        //Shoplogic ig idk rlly
        public void DrawCharacters()
        {








                //--

                //----------
                // Ayanokoji
                //----------
                Raylib.DrawRectangleRec(Characters.AyanokojiRect, Color.Brown);
                Raylib.DrawTexture(Characters.AyanokojiTexture, (int)Characters.AyanokojiRect.X, (int)Characters.AyanokojiRect.Y, Color.White);

                //----------
                // TOJI
                //----------
                Raylib.DrawRectangleRec(Characters.TojiRect, Color.Gray);
                Raylib.DrawTexture(Characters.TojiTexture, (int)Characters.TojiRect.X, (int)Characters.TojiRect.Y, Color.White);

                //----------
                // MADARA
                //----------

                Raylib.DrawRectangleRec(Characters.MadaraRect, Color.Red);
                Raylib.DrawTexture(Characters.MadaraTexture, (int)Characters.MadaraRect.X, (int)Characters.MadaraRect.Y, Color.White);

                //----------
                // Saitama
                //----------

                Raylib.DrawRectangleRec(Characters.SaitamaRect, Color.Yellow);
                Raylib.DrawTexture(Characters.SaitamaTexture, (int)Characters.SaitamaRect.X, (int)Characters.SaitamaRect.Y, Color.White);


                //----------
                // Akaza
                //----------

                Raylib.DrawRectangleRec(Characters.AkazaRect, Color.Blue);
                Raylib.DrawTexture(Characters.AkazaTexture, (int)Characters.AkazaRect.X, (int)Characters.AkazaRect.Y, Color.White);

                //----------
                // Yoruichi
                //----------

                Raylib.DrawRectangleRec(Characters.YoruichiRect, Color.DarkBrown);
                Raylib.DrawTexture(Characters.YoruichiTexture, (int)Characters.YoruichiRect.X, (int)Characters.YoruichiRect.Y, Color.White);

                //----------
                // Jotaro
                //----------

                Raylib.DrawRectangleRec(Characters.JotaroRect, Color.DarkBrown);
                Raylib.DrawTexture(Characters.JotaroTexture, (int)Characters.JotaroRect.X, (int)Characters.JotaroRect.Y, Color.White);


        }








        //Rectangles
        public static Rectangle Storebutton = new Rectangle(930, 730, 300, 50);
        public static Rectangle Backbutton = new Rectangle(30, 720, 150, 50);
        public static Rectangle Buybutton = new Rectangle(400, 720, 400, 50);
        public static Rectangle ShopWindow = new Rectangle(40, 40, 1200, 720);
        public static Rectangle Background = new Rectangle(0, 0, 1280, 800);

        //Textures
        public static Texture2D Backbuttontexture = Raylib.LoadTexture(@"Backbuttontexture.png");
        public static Texture2D Buybuttontexture = Raylib.LoadTexture(@"Buybuttontexture.png");


        public static Texture2D Shopbg = Raylib.LoadTexture(@"Shopbg.png");
        public static Texture2D Shopbg2 = Raylib.LoadTexture(@"Shopbg2.png");
        public static Texture2D Shopbg3 = Raylib.LoadTexture(@"Shopbg3.png");
        public static Texture2D Shopovrly = Raylib.LoadTexture(@"shopovrly.png");


        public static bool storebuttonispressed = false;
        public static bool backbuttonispressed = false;

        public static int wishPrice = 200;

        public Vector2 mousePos = Raylib.GetMousePosition();



        public void Draw()
        {

                Raylib.DrawTexture(Shopbg3, 0, 0, Color.White);
                Raylib.DrawTexture(Shopovrly, 32, 32, Color.White);
                Raylib.DrawText($"{Inventory.randomNumber}", 100, 100, 50, Color.Blue);




                //Raylib.DrawRectangleRec(Background, Color.DarkBrown);
                //Raylib.DrawRectangleRec(ShopWindow, Color.Brown);

                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.points}", new Vector2(880, 42), 50, 5, Color.White);
                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.gems}", new Vector2(720, 42), 50, 5, Color.White);
                //Raylib.DrawTextEx(Damage.MinecraftFont, $"{Rewards.ShopResetTimer}", new Vector2(100, 70), 50, 5, Color.White);





        }
        public void Drawstorebutton()
        {

                Raylib.DrawRectangleRec(Storebutton, Color.Brown);
                Raylib.DrawText("STORE", (int)Storebutton.X, (int)Storebutton.Y + 5, 40, Color.Black);

        }
        public void Drawbackbutton()
        {
                Raylib.DrawRectangleRec(Backbutton, Color.Green);
                Raylib.DrawTexture(Backbuttontexture, (int)Backbutton.X, (int)Backbutton.Y, Color.White);
                //Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5, 40, Color.Black);


        }
        public void DrawBuybutton()
        {
                Raylib.DrawRectangleRec(Buybutton, Color.Brown);
                Raylib.DrawTexture(Buybuttontexture, (int)Buybutton.X, (int)Buybutton.Y, Color.Blank);
                Raylib.DrawText("BUY", (int)Buybutton.X, (int)Buybutton.Y + 5, 40, Color.Black);

        }


        public void Button()
        {

                if (Raylib.CheckCollisionPointRec(mousePos, Storebutton))
                {

                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                storebuttonispressed = true;
                                backbuttonispressed = false;

                        }



                }

                if (Raylib.CheckCollisionPointRec(mousePos, Backbutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                backbuttonispressed = true;

                                if (storebuttonispressed == true)
                                {

                                        storebuttonispressed = false;

                                }
                                else if (Inventory.InventoryButtonispressed == true)
                                {

                                        Inventory.InventoryButtonispressed = false;
                                }

                        }
                }

                if (Raylib.CheckCollisionPointRec(mousePos, Buybutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {
                                if (Damage.gems >= wishPrice)
                                {

                                        Inventory.WishLogic();



                                }
                        }

                }


        }






}
public class Inventory
{
        Store store = new();



        public static Rectangle InventoryButton = new Rectangle(265, 600, 400, 50);
        public static Rectangle InvBackbutton = new Rectangle(30, 720, 150, 50);
        public static bool InventoryButtonispressed = false;

        public int inventorynum = 0;


        public void DrawInventory()
        {

                Raylib.DrawTexture(Store.Shopbg2, 0, 0, Color.White);

                foreach (Characters i in Player.Inventory)
                {



                        if (Player.Inventory.Count == inventorynum)
                        {
                                inventorynum++;

                        }

                        Raylib.DrawRectangleRec(Player.Inventory[inventorynum].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[inventorynum].Texture, (int)Player.Inventory[inventorynum].Rectangle.X, (int)Player.Inventory[inventorynum].Rectangle.Y, Color.White);



                }




        }
        public void DrawInventoryButton()
        {
                Raylib.DrawRectangleRec(InventoryButton, Color.Brown);
                Raylib.DrawText("Inventory", (int)InventoryButton.X, (int)InventoryButton.Y + 5, 40, Color.Black);
                //Raylib.DrawTexture(Buybuttontexture, (int)Buybutton.X, (int)Buybutton.Y, Color.Blank);

        }
        public void DrawInvbackbutton()
        {
                Raylib.DrawRectangleRec(InvBackbutton, Color.Green);
                Raylib.DrawTexture(Store.Backbuttontexture, (int)InvBackbutton.X, (int)InvBackbutton.Y, Color.White);
                //Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5, 40, Color.Black);


        }

        public void InventoryLogic()
        {
                if (Raylib.CheckCollisionPointRec(store.mousePos, InventoryButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                InventoryButtonispressed = true;

                                Store.backbuttonispressed = false;

                                Store.storebuttonispressed = false;

                        }
                }

                if (Raylib.CheckCollisionPointRec(store.mousePos, InvBackbutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                Store.backbuttonispressed = true;

                                if (Store.storebuttonispressed == true)
                                {

                                        Store.storebuttonispressed = false;

                                }
                                else if (Inventory.InventoryButtonispressed == true)
                                {

                                        Inventory.InventoryButtonispressed = false;
                                }

                        }
                }

        }
        public static Random random = new Random();
        public static Rectangle RewardPos = new Rectangle(new Vector2(500, 500), new Vector2(250, 250));

        public static Rectangle OriginalPos;
        public static Characters rewardedCharacter;
        public static bool rewardClaimed = true;
        public static int randomNumber;
        public static float rewardTimer = 5;
        public static void WishLogic()
        {

                Damage.gems -= 1;

                rewardTimer = 5;

                randomNumber = random.Next(1, 100);



                if (randomNumber <= 50)
                {

                        randomNumber = random.Next(1, 100);


                        if (randomNumber <= Rewards.CharactersInShop[1].Odds) // 50
                        {

                                rewardedCharacter = Rewards.CharactersInShop[0];

                        }
                        else if (randomNumber >= Rewards.CharactersInShop[1].Odds + 1) //50
                        {

                                rewardedCharacter = Rewards.CharactersInShop[1];

                        }

                }


                else if (randomNumber <= 53 && randomNumber >= 51) //3
                {
                        rewardedCharacter = Rewards.CharactersInShop[2]; //Madara
                }

                else if (randomNumber == 54)//1
                {
                        rewardedCharacter = Rewards.CharactersInShop[3];

                }

                else if (randomNumber <= 85 && randomNumber >= 55)//30
                {
                        rewardedCharacter = Rewards.CharactersInShop[4];

                }

                else if (randomNumber <= 95 && randomNumber >= 86)//9
                {
                        rewardedCharacter = Rewards.CharactersInShop[5];

                }

                else if (randomNumber <= 100 && randomNumber >= 96)//5
                {
                        rewardedCharacter = Rewards.CharactersInShop[6];
                }





                rewardClaimed = false;
                DrawReward();


        }

        public static void Update()
        {
                rewardTimer -= Raylib.GetFrameTime();
        }
        public static void DrawReward()
        {





                rewardTimer = 5;


                OriginalPos = rewardedCharacter.Rectangle;

                rewardedCharacter.Rectangle = RewardPos;


                
                if (rewardTimer >= 0)
                {
                        Raylib.DrawRectangle(0, 0, 1200, 800, Color.Brown);
                        Raylib.DrawRectangleRec(rewardedCharacter.Rectangle, Color.White);
                        Raylib.DrawTexture(rewardedCharacter.Texture, (int)rewardedCharacter.Rectangle.X, (int)rewardedCharacter.Rectangle.Y, Color.White);
                        Raylib.DrawText($"{rewardedCharacter.Name}", (int)rewardedCharacter.Rectangle.X, (int)rewardedCharacter.Rectangle.Y + 300, 10, Color.Violet);

                }

                if (rewardTimer <= 0)
                {
                        rewardClaimed = true;

                        Player.Inventory.Add(rewardedCharacter);

                        rewardedCharacter.Rectangle = OriginalPos;
                }







        }
}
