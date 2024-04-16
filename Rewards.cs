
using System.Numerics;



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

    public static int strawHatPrice = 20;
    public static int strawHatTextSize = 20;

    public static Upgrades StrawHat = new Upgrades("Straw Hat", 0, strawHatPrice, 1, Upgrades.Upgr1button);
    public static Upgrades Zanpakuto = new Upgrades("Zanpakuto", 0, 100, 5, Upgrades.Upgr2button);
    public static Upgrades DeathNote = new Upgrades("Death Note", 0, 1000, 20, Upgrades.Upgr3button);

    public void start()
    {

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
    public static Vector2 CurrentPos = new Vector2(0, 0);

    Random rnd = new Random();






    public void LoadCharacters()
    {

        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         💪 AYANOKOJI 📖       
        //=============================================================================================================================================================================

        Characters Ayanokoji = new Characters("Ayanokoji", 2, 300, 1, 50, 0, 7, 7, BuffList[0], Characters.AyanokojiRect, Characters.AyanokojiTexture, true);

        CharactersList.Add(Ayanokoji);

        if (Ayanokoji.InRotation == true)
        {

            CharactersInShop.Add(Ayanokoji);

        }




        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         🗡️ TOJI 🩸👧🔫       
        //=============================================================================================================================================================================

        Characters Toji = new Characters("Toji", 3, 500, 1, 50, 0, 1, 1, BuffList[0], Characters.TojiRect, Characters.TojiTexture, true);

        CharactersList.Add(Toji);


        if (Toji.InRotation == true)
        {

            CharactersInShop.Add(Toji);

        }


        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         🥷 MADARA 🪕       
        //=============================================================================================================================================================================


        Characters Madara = new Characters("Madara", 6, 500, 1, 3, 0, 1, 1, BuffList[0], Characters.MadaraRect, Characters.MadaraTexture, true);
        CharactersList.Add(Madara);


        if (Madara.InRotation == true)
        {

            CharactersInShop.Add(Madara);

        }


        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         1️⃣ SAITAMA 👊     
        //=============================================================================================================================================================================


        Characters Saitama = new Characters("Saitama", 7, 500, 1, 1, 0, 1, 1, BuffList[0], Characters.SaitamaRect, Characters.SaitamaTexture, true);
        CharactersList.Add(Saitama);


        if (Saitama.InRotation == true)
        {

            CharactersInShop.Add(Saitama);

        }




        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         ❄️ AKAZA ❄️      
        //=============================================================================================================================================================================

        
        Characters Akaza = new Characters("Akaza", 4, 500, 1, 40, 0, 1, 1, BuffList[0], Characters.AkazaRect, Characters.AkazaTexture, true);
        CharactersList.Add(Akaza);


        if (Akaza.InRotation == true)
        {

            CharactersInShop.Add(Akaza);

        }
        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||          ⚡YORUICHI🐈‍⬛      
        //=============================================================================================================================================================================

        Characters Yoruichi = new Characters("Yoruichi", 5, 500, 1, 10, 0, 1, 1, BuffList[0], Characters.YoruichiRect, Characters.YoruichiTexture, true);
        CharactersList.Add(Yoruichi);


        if (Yoruichi.InRotation == true)
        {

            CharactersInShop.Add(Yoruichi);

        }

        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||          Jotaro      
        //=============================================================================================================================================================================

        Characters Jotaro = new Characters("Jotaro", 6, 500, 1, 7, 0, 1, 1, BuffList[0], Characters.JotaroRect, Characters.JotaroTexture, true);
        CharactersList.Add(Jotaro);


        if (Jotaro.InRotation == true)
        {

            CharactersInShop.Add(Jotaro);

        }

    }

    

    public static List<Characters> CharactersInShop = new List<Characters>(7);

    public static double ShopResetTimer = 10;
    public void Shoplogic()
    {

        ShopResetTimer -= Raylib.GetFrameTime();



        if (ShopResetTimer <= 0)
        {


            ShopResetTimer = 1000;




        }



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

    public static Vector2 AyanoPos = Store.Position1.Position;
 
    //Rectangles
    
    public static Rectangle AyanokojiRect = new Rectangle(AyanoPos, 250, 250);
    public static Rectangle TojiRect = new Rectangle(Store.Position2.Position, 250, 250);
    public static Rectangle AkazaRect = new Rectangle(Store.Position3.Position, 250, 250);
    public static Rectangle YoruichiRect = new Rectangle(Store.Position4.Position, 250, 250);
    public static Rectangle MadaraRect = new Rectangle(Store.Position5.Position, 250, 250);
    public static Rectangle JotaroRect = new Rectangle(Store.Position6.Position, 250, 250);
    public static Rectangle SaitamaRect = new Rectangle(Store.SpecialPosition.Position, 250, 550);

    //Textures

    public static Texture2D AyanokojiTexture = Raylib.LoadTexture(@"AyanokojiSprite.png");
    public static Texture2D TojiTexture = Raylib.LoadTexture(@"TojiSprite.png");
    public static Texture2D MadaraTexture = Raylib.LoadTexture(@"MadaraSprite.png");
    public static Texture2D AkazaTexture = Raylib.LoadTexture(@"AkazaSprite.png");
    public static Texture2D JotaroTexture = Raylib.LoadTexture(@"JotaroSprite.png");
    public static Texture2D YoruichiTexture = Raylib.LoadTexture(@"YoruichiSprite.png");
    public static Texture2D SaitamaTexture = Raylib.LoadTexture(@"SaitamaSpriteBig.png");





    //--
    private string name;
    private double odds;
    private int positionNum;

    private short stars;
    private double dps;
    private double level;

    private bool inRotation;


    private PowerUps buffs;

    private Texture2D texture;

    private Rectangle rectangle;

    private double rectposX;
    private double rectposY;



    //Rectangles

    //
    public static int pp = 0;


    //






    public Characters(string name, short stars, double dps, double level, double odds, int positionNum, double rectposX, double rectposY, PowerUps buffs, Rectangle rectangle, Texture2D texture, bool inRotation)
    {
        this.name = name;
        this.stars = stars;
        this.dps = dps;
        this.level = level;
        this.odds = odds;
        this.buffs = buffs;
        this.rectangle = rectangle;
        this.texture = texture;
        this.inRotation = inRotation;
        this.positionNum = positionNum;
        this.rectposX = rectposX;
        this.rectposY = rectposY;

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
    public double Odds
    {
        get { return odds; }
        set { odds = value; }
    }
    public double RectposX
    {
        get { return rectposX; }
        set { rectposX = value; }
    }
    public double RectposY
    {
        get { return rectposY; }
        set { rectposY = value; }
    }
    public int PositionNum
    {
        get { return positionNum; }
        set { positionNum = value; }
    }
    public PowerUps Buffs
    {
        get { return buffs; }
        set { buffs = value; }
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
    public bool InRotation
    {
        get { return inRotation; }
        set { inRotation = value; }
    }










    public void Draw()
    {



    }




}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      ShopItems
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------









