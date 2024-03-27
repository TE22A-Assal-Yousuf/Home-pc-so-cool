using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


/*

how its gonna work

list of characters that hold all of the stats 

List of the charactes in the "shop" and if theyre in rotation

void shopreset
    if characters in rotation == true

        random number between 0 - List max

        Add random number to array (shop)

        repeat array 6 times 

int resettimer = 120

add to array(shop) {7} 

    if stars <= 4 give positions 1-4
    if stars > 4 <= 5 give positions 5-6
    if stars > 5 >= 6 give position 7

    int reset timer -= frame time

        if reset timer == 120 

            Remove all items in array(shop)

            Shopreset();














*/
class Rewards
{

    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //   =͟͟͞͞( ✌°∀° )☛       UPGRADES!!!                                                                                                                                                         
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------

    Vector2 mousePos = Raylib.GetMousePosition();

    public static List<Upgrades> UpgradesList = new List<Upgrades>();

    public int strawHatPrice = 20;
    public int strawHatTextSize = 20;

    public void start()
    {

        




        Upgrades StrawHat = new Upgrades("Straw Hat", 0, strawHatPrice, 1, Upgrades.Upgr1button);
        Upgrades Zanpakuto = new Upgrades("Zanpakuto", 0, 100, 5, Upgrades.Upgr2button);
        Upgrades DeathNote = new Upgrades("Death Note", 0, 1000, 20, Upgrades.Upgr3button);

        UpgradesList.Add(StrawHat);
        UpgradesList.Add(Zanpakuto);
        UpgradesList.Add(DeathNote);


        //strawhat
        Raylib.DrawRectangleRec(UpgradesList[0].Rectangle, Color.Brown);
        Raylib.DrawText($"{UpgradesList[0].Name}", (int)Upgrades.Upgr1button.X + 5, (int)Upgrades.Upgr1button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {UpgradesList[0].Price}$", (int)Upgrades.Upgr1button.X + 150, (int)Upgrades.Upgr1button.Y + 15, strawHatTextSize, Color.Black);
        Raylib.DrawText($"Count: {UpgradesList[0].Count}", (int)Upgrades.Upgr1button.X + 5, (int)Upgrades.Upgr1button.Y + 35, 10, Color.Black);

        //Zanpakuto

        Raylib.DrawRectangleRec(UpgradesList[1].Rectangle, Color.Brown);
        Raylib.DrawText($"{UpgradesList[1].Name}", (int)Upgrades.Upgr2button.X + 5, (int)Upgrades.Upgr2button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {UpgradesList[1].Price}$", (int)Upgrades.Upgr2button.X + 150, (int)Upgrades.Upgr2button.Y + 15, 20, Color.Black);
        Raylib.DrawText($"Count: {UpgradesList[1].Count}", (int)Upgrades.Upgr2button.X + 5, (int)Upgrades.Upgr2button.Y + 35, 10, Color.Black);

        //Death note
        if (Upgrades.unlocked3 == true)
        {
            Raylib.DrawRectangleRec(UpgradesList[2].Rectangle, Color.Brown);
            Raylib.DrawText($"{UpgradesList[2].Name}", (int)Upgrades.Upgr3button.X + 5, (int)Upgrades.Upgr3button.Y + 5, 20, Color.Black);
            Raylib.DrawText($"Price: {UpgradesList[2].Price}$", (int)Upgrades.Upgr3button.X + 150, (int)Upgrades.Upgr3button.Y + 15, 20, Color.Black);
            Raylib.DrawText($"Count: {UpgradesList[2].Count}", (int)Upgrades.Upgr3button.X + 5, (int)Upgrades.Upgr3button.Y + 35, 10, Color.Black);
        }




    }




    public void Upgradebuttons()
    {

        //Straw Hat

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr1button))
        {
            if (Damage.points >= UpgradesList[0].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[0].Price;

                    UpgradesList[0].Price += UpgradesList[0].Price / 100 * 15;
                    UpgradesList[0].Count++;

                    //
                    Player.autoDamage += UpgradesList[0].Upgradestat;

                    UpgradesList[0].Price = Math.Ceiling(UpgradesList[0].Price);


                }
            }
        }

        //Zanpakuto

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr2button))
        {
            if (Damage.points >= UpgradesList[1].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[1].Price;

                    UpgradesList[1].Price += UpgradesList[1].Price / 100 * 15;
                    UpgradesList[1].Count++;

                    //
                    Player.autoDamage += UpgradesList[1].Upgradestat;

                    UpgradesList[1].Price = Math.Ceiling(UpgradesList[1].Price);


                }
            }
        }

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr3button))
        {
            if (Damage.points >= UpgradesList[2].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[2].Price;

                    UpgradesList[2].Price += UpgradesList[2].Price / 100 * 15;
                    UpgradesList[2].Count++;

                    //
                    Player.autoDamage += UpgradesList[2].Upgradestat;

                    UpgradesList[2].Price = Math.Ceiling(UpgradesList[2].Price);


                }
            }
        }

        

        if (Damage.points >= 1000)
        {
            Upgrades.unlocked3 = true;
        }



    }
    
    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //   °˖ ✧◝(○ ヮ ○)◜✧˖ °       POWERUPS // BUFFS!!!                                                                                                                                                         
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------

    public static List<PowerUps> BuffList = new List<PowerUps>();

    PowerUps TwoXAutoDMG = new PowerUps("name", 0, 2, 0);
    PowerUps TwoXClickDMG = new PowerUps("name", 100, 0, 0);
    PowerUps PointsUp = new PowerUps("name", 0, 0, 1.5);


    public void BuffsAdd()
    {
        BuffList.Add(TwoXClickDMG);
    }

    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //   (⌐■_■)–︻╦╤─ -- --  -->CHARACTER LIST!!!<-- -- -- -- --                                                                                                                                                 
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    public static List<Characters> CharactersList = new List<Characters>();


    public void DrawCharacters()
    {
        Characters Ayanokoji = new Characters("Ayanokoji", 2, 300, 1, 65, BuffList[0], Characters.AyanokojiRect, Characters.AyanokojiTexture);
        Characters Toji = new Characters("Toji", 3, 500, 1, 30, BuffList[0], Characters.TojiRect, Characters.TojiTexture);
        Characters Madara = new Characters("Madara", 3, 500, 1, 65, BuffList[0], Characters.AyanokojiRect, Characters.AyanokojiTexture);
        Characters Saitama = new Characters("Saitama", 3, 500, 1, 65, BuffList[0], Characters.AyanokojiRect, Characters.AyanokojiTexture);

        CharactersList.Add(Ayanokoji);
        CharactersList.Add(Toji);
        CharactersList.Add(Madara);
        CharactersList.Add(Saitama);


        //--

        Raylib.DrawRectangleRec(Characters.Madara, Color.Red);
        Raylib.DrawRectangleRec(Characters.Saitama, Color.Yellow);

        //--

        // Ayanokoji

        Raylib.DrawRectangleRec(CharactersList[0].Rectangle,Color.Brown);
        //Raylib.DrawTexture(CharactersList[0].Texture, (int)CharactersList[0].Rectangle.X, (int)CharactersList[0].Rectangle.Y, Color.White);

        // Tjoi

        Raylib.DrawRectangleRec(CharactersList[1].Rectangle, Color.Black);
        //Raylib.DrawTexture(CharactersList[1].Texture, (int)CharactersList[1].Rectangle.X, (int)CharactersList[1].Rectangle.Y, Color.White);
    }

    
}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      UPGRADES
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class Upgrades
{
    public static Rectangle Upgr2button = new Rectangle(930, 275, 300, 50);
    public static Rectangle Upgr3button = new Rectangle(930, 350, 300, 50);
    public static Rectangle Upgr4button = new Rectangle(930, 425, 300, 50);

    public static bool unlocked3 = false;
    private string name;
    private int count;
    private double price;

    private double upgradestat;

    private Rectangle rectangle;


    public static Rectangle Upgr1button = new Rectangle(930, 200, 300, 50);


    public Upgrades(string name, int count, double price, double upgradestat, Rectangle rectangle)
    {
        this.name = name;
        this.count = count;
        this.price = price;
        this.upgradestat = upgradestat;
        this.rectangle = rectangle;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Count
    {
        get { return count; }
        set { count = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public double Upgradestat
    {
        get { return upgradestat; }
        set { upgradestat = value; }
    }
    public Rectangle Rectangle
    {
        get { return rectangle; }
        set { rectangle = value; }
    }








}
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      PowerUps
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class PowerUps
{
    private string name;
    private double autoDamageBuff;
    private double clickDamageBuff;
    private double pointsBuff;

    public PowerUps(string name, double autoDamageBuff, double clickDamageBuff, double pointsBuff)
    {
        this.name = name;
        this.autoDamageBuff = autoDamageBuff;
        this.clickDamageBuff = clickDamageBuff;
        this.pointsBuff = pointsBuff;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double AutoDamageBuff
    {
        get { return autoDamageBuff; }
        set { autoDamageBuff = value; }
    }

    public double ClickDamageBuff
    {
        get { return clickDamageBuff; }
        set { clickDamageBuff = value; }
    }

    public double PointsBuff
    {
        get { return pointsBuff; }
        set { pointsBuff = value; }
    }

    //---------------------------------------------------------------------------------------------
    

}
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      Characters
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class Characters
{


    //--



    //--
    private string name;
    private int odds;
    private short stars;
    private double dps;
    private double level;
    private PowerUps buffs;

    private Texture2D texture;

    private Rectangle rectangle;


    //Rectangles

    //
    public static int pp = 0;


    //

    public static Rectangle AyanokojiRect = new Rectangle(Store.ShopListPositions[pp].X, Store.ShopListPositions[pp].Y, 250, 250);
    public static Rectangle TojiRect = new Rectangle(360, 128, 250, 250);
    public static Rectangle Madara = new Rectangle(642, 128, 250, 250);
    public static Rectangle Saitama = new Rectangle(924, 128, 250, 550);

     //Textures

    public static Texture2D AyanokojiTexture = Raylib.LoadTexture(@"Meo.png");
    public static Texture2D TojiTexture = Raylib.LoadTexture(@"Julle.png");




    public Characters (string name, short stars, double dps, double level, int odds, PowerUps buffs, Rectangle rectangle, Texture2D texture)
    {
        this.name = name;
        this.stars = stars;
        this.dps = dps;
        this.level = level;
        this.odds = odds;
        this.buffs = buffs;
        this.rectangle = rectangle;
        this.texture = texture;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public short Stars
    {
        get { return stars; }
        set { stars = value; }
    }
    public double DPS
    {
        get { return dps; }
        set { dps = value; }
    }
    public double Level
    {
        get { return level; }
        set { level = value; }
    }
    public int Odds
    {
        get{ return odds; }
        set{ odds = value; }
    }
    public PowerUps Buffs
    {
        get{ return buffs;}
        set{ buffs = value;} 
    }
    public Rectangle Rectangle
    {
        get { return rectangle; }
        set { rectangle = value; }
    }
    public Texture2D Texture
    {
        get { return texture; }
        set { texture = value; }
    }


    
    
    
    

    


    public void Draw()
    {
        


    }




}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      ShopItems
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

public class ShopItems
{

    private Characters characters;
    private bool inRotation;

    public ShopItems (Characters characters, bool inRotation)
    {

        this.characters = characters;
        this.inRotation = inRotation;

    }

    public bool InRotation
    {
        get{ return inRotation; }
        set{ inRotation = value;}
    }

}







