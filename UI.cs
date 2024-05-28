using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class UI
{

        Sound bgMusic = Raylib.LoadSound("Neverseemeagain.mp3");
        public static Texture2D gameBackground = Raylib.LoadTexture(@"Gamebackground.png");

        //referance lines
        public void DrawLines()
        {
                Raylib.DrawLine(10, 0, 10, 800, Color.Red);//side 1
                Raylib.DrawLine(460, 0, 460, 800, Color.Red);//side 2
                Raylib.DrawLine(1270, 0, 1270, 800, Color.Red);//down 2
                Raylib.DrawLine(870, 0, 870, 800, Color.Red);//down 1
        }


        public void Draw()
        {
                //draw up games
                Raylib.DrawTexture(gameBackground, 0, 0, Color.White);


                Raylib.DrawTextEx(Damage.minecrafterFont, "Points:", new Vector2(575, 230), 40, 5, Color.White);

                Raylib.DrawTextEx(Damage.minecraftFont, $"{Damage.points}", new Vector2(520, 270), 50, 5, Color.White);


                Raylib.DrawTextEx(Damage.minecrafterFont, $"DPS {Player.autoDamage}", new Vector2(930, 50), 20, 5, Color.White);

                Raylib.DrawTextEx(Damage.minecraftFont, $"Gems: {Damage.gems}", new Vector2(925, 105), 50, 5, Color.White);
                //Raylib.DrawTextEx(Damage.MinecraftFont, $"{Rewards.ShopResetTimer}", new Vector2(100, 70), 50, 5, Color.White);

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
        public static List<Rectangle> positionsList = new List<Rectangle>();


        public static Rectangle position1 = new Rectangle(new Vector2(78, 128), new Vector2(250, 250));
        public static Rectangle position2 = new Rectangle(new Vector2(360, 128), new Vector2(250, 250));
        public static Rectangle position3 = new Rectangle(new Vector2(642, 128), new Vector2(250, 250));
        public static Rectangle position4 = new Rectangle(new Vector2(78, 420), new Vector2(250, 250));
        public static Rectangle position5 = new Rectangle(new Vector2(360, 420), new Vector2(250, 250));
        public static Rectangle position6 = new Rectangle(new Vector2(642, 420), new Vector2(250, 250));
        public static Rectangle specialPosition = new Rectangle(new Vector2(924, 128), new Vector2(250, 550));

        public void postitionDraw()
        {
                positionsList.Add(position1);
                positionsList.Add(position2);
                positionsList.Add(position3);
                positionsList.Add(position4);
                positionsList.Add(position5);
                positionsList.Add(position6);
                positionsList.Add(specialPosition);

                Raylib.DrawRectangleRec(position1, Color.Black);
                Raylib.DrawRectangleRec(position2, Color.Black);
                Raylib.DrawRectangleRec(position3, Color.Black);
                Raylib.DrawRectangleRec(position4, Color.Black);
                Raylib.DrawRectangleRec(position5, Color.Black);
                Raylib.DrawRectangleRec(position6, Color.Black);
                Raylib.DrawRectangleRec(specialPosition, Color.Black);


        }
        //Shoplogic ig idk rlly
        public void DrawCharacters()
        {








                //--

                //----------
                // Ayanokoji
                //----------
                Raylib.DrawRectangleRec(Characters.ayanokojiRect, Color.Brown);
                Raylib.DrawTexture(Characters.ayanokojiTexture, (int)Characters.ayanokojiRect.X, (int)Characters.ayanokojiRect.Y, Color.White);

                //----------
                // TOJI
                //----------
                Raylib.DrawRectangleRec(Characters.tojiRect, Color.Gray);
                Raylib.DrawTexture(Characters.tojiTexture, (int)Characters.tojiRect.X, (int)Characters.tojiRect.Y, Color.White);

                //----------
                // MADARA
                //----------

                Raylib.DrawRectangleRec(Characters.madaraRect, Color.Red);
                Raylib.DrawTexture(Characters.madaraTexture, (int)Characters.madaraRect.X, (int)Characters.madaraRect.Y, Color.White);

                //----------
                // Saitama
                //----------

                Raylib.DrawRectangleRec(Characters.saitamaRect, Color.Yellow);
                Raylib.DrawTexture(Characters.saitamaTexture, (int)Characters.saitamaRect.X, (int)Characters.saitamaRect.Y, Color.White);


                //----------
                // Akaza
                //----------

                Raylib.DrawRectangleRec(Characters.akazaRect, Color.Blue);
                Raylib.DrawTexture(Characters.akazaTexture, (int)Characters.akazaRect.X, (int)Characters.akazaRect.Y, Color.White);

                //----------
                // Yoruichi
                //----------

                Raylib.DrawRectangleRec(Characters.yoruichiRect, Color.DarkBrown);
                Raylib.DrawTexture(Characters.yoruichiTexture, (int)Characters.yoruichiRect.X, (int)Characters.yoruichiRect.Y, Color.White);

                //----------
                // Jotaro
                //----------

                Raylib.DrawRectangleRec(Characters.jotaroRect, Color.DarkBrown);
                Raylib.DrawTexture(Characters.jotaroTexture, (int)Characters.jotaroRect.X, (int)Characters.jotaroRect.Y, Color.White);


        }








        //Rectangles
        public static Rectangle storeButton = new Rectangle(930, 730, 300, 50);
        public static Rectangle backButton = new Rectangle(30, 720, 150, 50);
        public static Rectangle buyButton = new Rectangle(400, 720, 400, 50);
        public static Rectangle shopWindow = new Rectangle(40, 40, 1200, 720);
        public static Rectangle background = new Rectangle(0, 0, 1280, 800);

        //Textures
        public static Texture2D backButtonTexture = Raylib.LoadTexture(@"Backbuttontexture.png");
        public static Texture2D buyButtonTexture = Raylib.LoadTexture(@"Buybuttontexture.png");


        public static Texture2D shopBg = Raylib.LoadTexture(@"Shopbg.png");
        public static Texture2D shopBkg2 = Raylib.LoadTexture(@"Shopbg2.png");
        public static Texture2D shopBkg3 = Raylib.LoadTexture(@"Shopbg3.png");
        public static Texture2D shopOvrly = Raylib.LoadTexture(@"shopovrly.png");


        public static bool storeButtonIsPressed = false;
        public static bool backButtonIsPressed = false;

        public static int wishPrice = 600;

        public Vector2 mousePos = Raylib.GetMousePosition();


        //draw store ui
        public void Draw()
        {

                Raylib.DrawTexture(shopBkg3, 0, 0, Color.White);
                Raylib.DrawTexture(shopOvrly, 32, 32, Color.White);
                Raylib.DrawText($"{Inventory.randomNumber}", 100, 100, 50, Color.Blue);




                //Raylib.DrawRectangleRec(Background, Color.DarkBrown);
                //Raylib.DrawRectangleRec(ShopWindow, Color.Brown);

                Raylib.DrawTextEx(Damage.minecraftFont, $"{Damage.points}", new Vector2(880, 42), 50, 5, Color.White);
                Raylib.DrawTextEx(Damage.minecraftFont, $"{Damage.gems}", new Vector2(720, 42), 50, 5, Color.White);
                //Raylib.DrawTextEx(Damage.MinecraftFont, $"{Rewards.ShopResetTimer}", new Vector2(100, 70), 50, 5, Color.White);





        }
        //draws store buttons
        public void Drawstorebutton()
        {

                Raylib.DrawRectangleRec(storeButton, Color.Brown);
                Raylib.DrawText("STORE", (int)storeButton.X, (int)storeButton.Y + 5, 40, Color.Black);

        }
        public void Drawbackbutton()
        {
                Raylib.DrawRectangleRec(backButton, Color.Green);
                Raylib.DrawTexture(backButtonTexture, (int)backButton.X, (int)backButton.Y, Color.White);
                //Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5, 40, Color.Black);


        }
        public void DrawBuybutton()
        {
                Raylib.DrawRectangleRec(buyButton, Color.Brown);
                Raylib.DrawTexture(buyButtonTexture, (int)buyButton.X, (int)buyButton.Y, Color.Blank);
                Raylib.DrawText("BUY", (int)buyButton.X, (int)buyButton.Y + 5, 40, Color.Black);

        }

        //button logic
        public void Button()
        {

                if (Raylib.CheckCollisionPointRec(mousePos, storeButton))
                {

                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                storeButtonIsPressed = true;
                                backButtonIsPressed = false;

                        }



                }

                if (Raylib.CheckCollisionPointRec(mousePos, backButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                backButtonIsPressed = true;

                                if (storeButtonIsPressed == true)
                                {

                                        storeButtonIsPressed = false;

                                }
                                else if (Inventory.inventoryButtonispressed == true)
                                {

                                        Inventory.inventoryButtonispressed = false;
                                }

                        }
                }

                if (Raylib.CheckCollisionPointRec(mousePos, buyButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {
                                if (Damage.gems >= wishPrice)
                                {

                                        Inventory.WishLogic();



                                }
                                else if (Damage.gems < wishPrice)
                                {
                                        
                                        Raylib.DrawText("Not enough money", 300, 500 + 5, 40, Color.White);

                                }
                        }

                }


        }






}
public class Inventory
{
        Store store = new();

        public static List<Rectangle> inventoryPositions = new List<Rectangle>();
        public static Rectangle inventoryPos = new Rectangle(250 , 150, 200, 200);
        public static Rectangle inventoryPos2 = new Rectangle(250 + 250, 150, 200, 200);
        public static Rectangle inventoryPos3 = new Rectangle(250 + (250 * 2), 150, 200, 200);
        public static Rectangle inventoryPos4 = new Rectangle(250 + (250 * 3)  , 150, 200, 200);
        public static Rectangle inventoryPos5 = new Rectangle(250, 400, 200, 200);
        public static Rectangle inventoryPos6 = new Rectangle(250+ (250), 400, 200, 200);
        public static Rectangle inventoryPos7 = new Rectangle(250+ (250 * 2), 400, 200, 200);
        public static Rectangle inventoryPos8 = new Rectangle(250+ (250 * 3), 400, 200, 200);

        public static Rectangle inventoryButton = new Rectangle(265, 600, 400, 50);
        public static Rectangle invBackButton = new Rectangle(30, 600, 150, 50);
        public static Rectangle rollAgainButton = new Rectangle(1000, 600, 150, 50);

        public static bool rollAgainButtonIsPressed = false;

        public static bool inventoryButtonispressed = false;

        public int inventorynum = 0;

        //loads in inventory positions
        public void LoadInventory()
        {
                inventoryPositions.Add(inventoryPos);
                inventoryPositions.Add(inventoryPos2);
                inventoryPositions.Add(inventoryPos3);
                inventoryPositions.Add(inventoryPos4);
                inventoryPositions.Add(inventoryPos5);
                inventoryPositions.Add(inventoryPos6);
                inventoryPositions.Add(inventoryPos7);
                inventoryPositions.Add(inventoryPos8);

        }

        //draws the inventory 
        public void DrawInventory()
        {
                Raylib.DrawTexture(Store.shopBkg2, 0, 0, Color.White);


             

                Raylib.DrawRectangleRec(inventoryPositions[0], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[1], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[2], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[3], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[4], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[5], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[6], Color.DarkBrown);
                Raylib.DrawRectangleRec(inventoryPositions[7], Color.DarkBrown);
                







                /*foreach (Characters i in Player.Inventory)
                {


                        

                        Raylib.DrawRectangleRec(Player.Inventory[0].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[0].Texture, (int)Player.Inventory[0].Rectangle.X, (int)Player.Inventory[0].Rectangle.Y, Color.White);

                        Raylib.DrawRectangleRec(Player.Inventory[1].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[1].Texture, (int)Player.Inventory[1].Rectangle.X, (int)Player.Inventory[1].Rectangle.Y, Color.White);

                        Raylib.DrawRectangleRec(Player.Inventory[2].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[2].Texture, (int)Player.Inventory[2].Rectangle.X, (int)Player.Inventory[2].Rectangle.Y, Color.White);

                        Raylib.DrawRectangleRec(Player.Inventory[3].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[3].Texture, (int)Player.Inventory[3].Rectangle.X, (int)Player.Inventory[3].Rectangle.Y, Color.White);

                        Raylib.DrawRectangleRec(Player.Inventory[4].Rectangle, Color.White);
                        Raylib.DrawTexture(Player.Inventory[4].Texture, (int)Player.Inventory[4].Rectangle.X, (int)Player.Inventory[4].Rectangle.Y, Color.White);



                       Player.Inventory[0].Rectangle = inventoryPositions[0];
                       Player.Inventory[1].Rectangle = inventoryPositions[1];
                       Player.Inventory[2].Rectangle = inventoryPositions[2];
                       Player.Inventory[3].Rectangle = inventoryPositions[3];
                }*/




        }

        //draw inventory buttins
        public void DrawInventoryButton()
        {
                Raylib.DrawRectangleRec(inventoryButton, Color.Brown);
                Raylib.DrawText("Inventory", (int)inventoryButton.X, (int)inventoryButton.Y + 5, 40, Color.Black);
                //Raylib.DrawTexture(Buybuttontexture, (int)Buybutton.X, (int)Buybutton.Y, Color.Blank);

        }
        public void DrawInvbackbutton()
        {
                Raylib.DrawRectangleRec(invBackButton, Color.Green);
                Raylib.DrawTexture(Store.backButtonTexture, (int)invBackButton.X, (int)invBackButton.Y, Color.White);
                //Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5, 40, Color.Black);


        }
        public void DrawRollAgainButton()
        {
                Raylib.DrawRectangleRec(rollAgainButton, Color.Green);
                //Raylib.DrawTexture(Store.Backbuttontexture, (int)InvBackButton.X, (int)InvBackButton.Y, Color.White);
                Raylib.DrawText("RollAgiain", (int)rollAgainButton.X, (int)rollAgainButton.Y + 5, 40, Color.Black);


        }

        //handels all the inventory button logic
        public void InventoryLogic()
        {
                if (Raylib.CheckCollisionPointRec(store.mousePos, inventoryButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                inventoryButtonispressed = true;

                                Store.backButtonIsPressed = false;

                                Store.storeButtonIsPressed = false;

                        }
                }

                if (Raylib.CheckCollisionPointRec(store.mousePos, invBackButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                Store.backButtonIsPressed = true;

                                if (Store.storeButtonIsPressed == true)
                                {

                                        Store.storeButtonIsPressed = false;

                                }
                                else if (inventoryButtonispressed == true)
                                {

                                        inventoryButtonispressed = false;
                                }

                        }
                }

                if (Raylib.CheckCollisionPointRec(store.mousePos, rollAgainButton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {
                                if (Damage.gems >= Store.wishPrice)
                                {

                                        rollAgainButtonIsPressed = true;

                                        WishLogic();



                                }
                        }

                }

        }
        public static Random random = new Random();
        public static Rectangle RewardPos = new Rectangle(new Vector2(500, 500), new Vector2(250, 250));

        public static Rectangle originalPos;
        public static Characters rewardedCharacter;
        public static bool rewardClaimed = true;
        public static int randomNumber;
        public static float rewardTimer = 5;

        //handels the buy system/logic
        public static void WishLogic()
        {

                Damage.gems -= 1;

                rewardTimer = 5;

                randomNumber = random.Next(1, 100);



                if (randomNumber <= 50)
                {

                        randomNumber = random.Next(1, 100);


                        if (randomNumber <= Rewards.charactersInShop[1].Odds) // 50
                        {

                                rewardedCharacter = Rewards.charactersInShop[0];

                        }
                        else if (randomNumber >= Rewards.charactersInShop[1].Odds + 1) //50
                        {

                                rewardedCharacter = Rewards.charactersInShop[1];

                        }

                }


                else if (randomNumber <= 53 && randomNumber >= 51) //3
                {
                        rewardedCharacter = Rewards.charactersInShop[2]; //Madara
                }

                else if (randomNumber == 54)//1
                {
                        rewardedCharacter = Rewards.charactersInShop[3];

                }

                else if (randomNumber <= 85 && randomNumber >= 55)//30
                {
                        rewardedCharacter = Rewards.charactersInShop[4];

                }

                else if (randomNumber <= 95 && randomNumber >= 86)//9
                {
                        rewardedCharacter = Rewards.charactersInShop[5];

                }

                else if (randomNumber <= 100 && randomNumber >= 96)//5
                {
                        rewardedCharacter = Rewards.charactersInShop[6];
                }





                rewardClaimed = false;
                DrawReward();


        }

        
        /*public static void Update()
        {
                rewardTimer -= Raylib.GetFrameTime();
        }*/

        //the logic for showing you the reward that you got 
        public static void DrawReward()
        {





                //rewardTimer = 5;


                originalPos = inventoryPositions[0];

                rewardedCharacter.Rectangle = RewardPos;



                if (rewardTimer >= 0 || rewardClaimed == false)
                {
                        Raylib.DrawRectangle(0, 0, 1200, 800, Color.Brown);
                        Raylib.DrawRectangleRec(rewardedCharacter.Rectangle, Color.White);
                        Raylib.DrawTexture(rewardedCharacter.Texture, (int)rewardedCharacter.Rectangle.X, (int)rewardedCharacter.Rectangle.Y, Color.White);
                        Raylib.DrawText($"{rewardedCharacter.Name}", (int)rewardedCharacter.Rectangle.X, (int)rewardedCharacter.Rectangle.Y + 300, 10, Color.Violet);

                }

                if (rewardTimer <= 0 || rewardClaimed == true)
                {
                        Player.inventory.Add(rewardedCharacter);

                        rewardedCharacter.Rectangle = originalPos;
                }


                


                Raylib.DrawTextEx(Damage.minecraftFont, $"{Damage.points}", new Vector2(880, 42), 50, 5, Color.White);
                Raylib.DrawTextEx(Damage.minecraftFont, $"{Damage.gems}", new Vector2(720, 42), 50, 5, Color.White);

        }
}
 