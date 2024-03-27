using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class UI
{

        Sound bgmusic = Raylib.LoadSound("Neverseemeagain.mp3");
        public static Texture2D GameBackground = Raylib.LoadTexture(@"Gamebackground.png");

        public void DrawLines()
        {
                Raylib.DrawLine(10, 0, 10, 800, Color.Red);
                Raylib.DrawLine(460, 0, 460, 800, Color.Red);
                Raylib.DrawLine(1270, 0, 1270, 800, Color.Red);
                Raylib.DrawLine(870, 0, 870, 800, Color.Red);
        }
        public void Draw()
        {
                Raylib.DrawTexture(GameBackground, 0, 0, Color.White);


                Raylib.DrawTextEx(Damage.MinecrafterFont, "Points:", new Vector2(575, 230), 40, 5, Color.White);
                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.points}", new Vector2(520, 270), 50, 5, Color.White);

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

        public static List<Rectangle> ShopListPositions = new List<Rectangle>();

        Rectangle Position1 = new Rectangle(new Vector2(78, 128), new Vector2(250,250));
        Rectangle Position2 = new Rectangle(new Vector2(360, 128), new Vector2(250,250));
        Rectangle Position3 = new Rectangle(new Vector2(642, 128), new Vector2(250,250));
        Rectangle Position4 = new Rectangle(new Vector2(78, 420), new Vector2(250,250));
        Rectangle Position5 = new Rectangle(new Vector2(360, 420), new Vector2(250,250));
        Rectangle Position6 = new Rectangle(new Vector2(642, 420), new Vector2(250,250));
        Rectangle SpecialPosition = new Rectangle(new Vector2(924, 128), new Vector2(250,550));

        public void postitionDraw()
        {
                ShopListPositions.Add(Position1);
                ShopListPositions.Add(Position2);
                ShopListPositions.Add(Position3);

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

        Vector2 mousePos = Raylib.GetMousePosition();

        

        public void Draw()
        {

                Raylib.DrawTexture(Shopbg3, 0, 0, Color.White);
                Raylib.DrawTexture(Shopovrly, 32, 32, Color.White);

                

                //Raylib.DrawRectangleRec(Background, Color.DarkBrown);
                //Raylib.DrawRectangleRec(ShopWindow, Color.Brown);

                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.points}", new Vector2(880, 42), 50, 5, Color.White);
                Raylib.DrawTextEx(Damage.MinecraftFont, $"{Damage.gems}", new Vector2(720, 42), 50, 5, Color.White);




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
                                storebuttonispressed = false;

                        }
                }
                if (Raylib.CheckCollisionPointRec(mousePos, Buybutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {
                                if (Damage.points >= wishPrice)
                                {

                                        Damage.points -= 200;
                                        Player.autoDamage += 200;

                                }
                        }

                }


        }


        

}
