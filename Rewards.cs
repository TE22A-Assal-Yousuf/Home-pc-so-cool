
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

    public static List<Upgrades> upgradesList = new List<Upgrades>();

    public static int strawHatPrice = 20;
    public static int strawHatTextSize = 20;

    public static Upgrades strawHat = new Upgrades("Straw Hat", 0, strawHatPrice, 1, Upgrades.upgr1button);
    public static Upgrades zanpakuto = new Upgrades("Zanpakuto", 0, 100, 5, Upgrades.upgr2button);
    public static Upgrades deathNote = new Upgrades("Death Note", 0, 1000, 20, Upgrades.upgr3button);
    public static Upgrades micke = new Upgrades("Death Note", 0, 1000, 20, Upgrades.upgr1button);

    public void start()
    {

        upgradesList.Add(strawHat);
        upgradesList.Add(zanpakuto);
        upgradesList.Add(deathNote);


        //strawhat
        Raylib.DrawRectangleRec(upgradesList[0].Rectangle, Color.Brown);
        Raylib.DrawText($"{upgradesList[0].Name}", (int)Upgrades.upgr1button.X + 5, (int)Upgrades.upgr1button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {upgradesList[0].Price}$", (int)Upgrades.upgr1button.X + 150, (int)Upgrades.upgr1button.Y + 15, strawHatTextSize, Color.Black);
        Raylib.DrawText($"Count: {upgradesList[0].Count}", (int)Upgrades.upgr1button.X + 5, (int)Upgrades.upgr1button.Y + 35, 10, Color.Black);

        //Zanpakuto

        Raylib.DrawRectangleRec(upgradesList[1].Rectangle, Color.Brown);
        Raylib.DrawText($"{upgradesList[1].Name}", (int)Upgrades.upgr2button.X + 5, (int)Upgrades.upgr2button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {upgradesList[1].Price}$", (int)Upgrades.upgr2button.X + 150, (int)Upgrades.upgr2button.Y + 15, 20, Color.Black);
        Raylib.DrawText($"Count: {upgradesList[1].Count}", (int)Upgrades.upgr2button.X + 5, (int)Upgrades.upgr2button.Y + 35, 10, Color.Black);

        //Death note
        if (Upgrades.unlocked3 == true)
        {
            Raylib.DrawRectangleRec(upgradesList[2].Rectangle, Color.Brown);
            Raylib.DrawText($"{upgradesList[2].Name}", (int)Upgrades.upgr3button.X + 5, (int)Upgrades.upgr3button.Y + 5, 20, Color.Black);
            Raylib.DrawText($"Price: {upgradesList[2].Price}$", (int)Upgrades.upgr3button.X + 150, (int)Upgrades.upgr3button.Y + 15, 20, Color.Black);
            Raylib.DrawText($"Count: {upgradesList[2].Count}", (int)Upgrades.upgr3button.X + 5, (int)Upgrades.upgr3button.Y + 35, 10, Color.Black);
        }




    }




    public void Upgradebuttons()
    {

        //Straw Hat

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.upgr1button))
        {
            if (Damage.points >= upgradesList[0].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= upgradesList[0].Price;

                    upgradesList[0].Price += upgradesList[0].Price / 100 * 15;
                    upgradesList[0].Count++;

                    //
                    Player.autoDamage += upgradesList[0].Upgradestat;

                    upgradesList[0].Price = Math.Ceiling(upgradesList[0].Price);


                }
            }
        }

        //Zanpakuto

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.upgr2button))
        {
            if (Damage.points >= upgradesList[1].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= upgradesList[1].Price;

                    upgradesList[1].Price += upgradesList[1].Price / 100 * 15;
                    upgradesList[1].Count++;

                    //
                    Player.autoDamage += upgradesList[1].Upgradestat;

                    upgradesList[1].Price = Math.Ceiling(upgradesList[1].Price);


                }
            }
        }

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.upgr3button))
        {
            if (Damage.points >= upgradesList[2].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= upgradesList[2].Price;

                    upgradesList[2].Price += upgradesList[2].Price / 100 * 15;
                    upgradesList[2].Count++;

                    //
                    Player.autoDamage += upgradesList[2].Upgradestat;

                    upgradesList[2].Price = Math.Ceiling(upgradesList[2].Price);


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

    public static List<PowerUps> buffList = new List<PowerUps>();

    PowerUps twoXAutoDMG = new PowerUps("name", 0, 2, 0);
    PowerUps twoXClickDMG = new PowerUps("name", 100, 0, 0);
    PowerUps pointsUp = new PowerUps("name", 0, 0, 1.5);


    public void BuffsAdd()
    {
        buffList.Add(twoXClickDMG);
    }

    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //   (⌐■_■)–︻╦╤─ -- --  -->CHARACTER LIST!!!<-- -- -- -- --                                                                                                                                                 
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //------------------------------------//------------------------------------//------------------------------------//------------------------------------//------------------------------------
    public static List<Characters> charactersList = new List<Characters>();
    public static Vector2 currentPos = new Vector2(0, 0);

    Random rnd = new Random();






    public void LoadCharacters()
    {

        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         💪 AYANOKOJI 📖       
        //=============================================================================================================================================================================

        Characters ayanokoji = new Characters("Ayanokoji", 2, 300, 1, 50, 0, 7, 7, buffList[0], Characters.ayanokojiRect, Characters.ayanokojiTexture, true);

        charactersList.Add(ayanokoji);

        if (ayanokoji.InRotation == true)
        {

            charactersInShop.Add(ayanokoji);

        }




        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         🗡️ TOJI 🩸👧🔫       
        //=============================================================================================================================================================================

        Characters toji = new Characters("Toji", 3, 500, 1, 50, 0, 1, 1, buffList[0], Characters.tojiRect, Characters.tojiTexture, true);

        charactersList.Add(toji);


        if (toji.InRotation == true)
        {

            charactersInShop.Add(toji);

        }


        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         🥷 MADARA 🪕       
        //=============================================================================================================================================================================


        Characters madara = new Characters("Madara", 6, 500, 1, 3, 0, 1, 1, buffList[0], Characters.madaraRect, Characters.madaraTexture, true);
        charactersList.Add(madara);


        if (madara.InRotation == true)
        {

            charactersInShop.Add(madara);

        }


        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         1️⃣ SAITAMA 👊     
        //=============================================================================================================================================================================


        Characters saitama = new Characters("Saitama", 7, 500, 1, 1, 0, 1, 1, buffList[0], Characters.saitamaRect, Characters.saitamaTexture, true);
        charactersList.Add(saitama);


        if (saitama.InRotation == true)
        {

            charactersInShop.Add(saitama);

        }




        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||         ❄️ AKAZA ❄️      
        //=============================================================================================================================================================================

        
        Characters akaza = new Characters("Akaza", 4, 500, 1, 40, 0, 1, 1, buffList[0], Characters.akazaRect, Characters.akazaTexture, true);
        charactersList.Add(akaza);


        if (akaza.InRotation == true)
        {

            charactersInShop.Add(akaza);

        }
        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||          ⚡YORUICHI🐈‍⬛      
        //=============================================================================================================================================================================

        Characters yoruichi = new Characters("Yoruichi", 5, 500, 1, 10, 0, 1, 1, buffList[0], Characters.yoruichiRect, Characters.yoruichiTexture, true);
        charactersList.Add(yoruichi);


        if (yoruichi.InRotation == true)
        {

            charactersInShop.Add(yoruichi);

        }

        //=============================================================================================================================================================================
        // (ง •̀_•́)ง ||          Jotaro      
        //=============================================================================================================================================================================

        Characters jotaro = new Characters("Jotaro", 6, 500, 1, 7, 0, 1, 1, buffList[0], Characters.jotaroRect, Characters.jotaroTexture, true);
        charactersList.Add(jotaro);


        if (jotaro.InRotation == true)
        {

            charactersInShop.Add(jotaro);

        }

    }

    

    public static List<Characters> charactersInShop = new List<Characters>(7);




}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                      UPGRADES
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class Upgrades
{
    public static Rectangle upgr2button = new Rectangle(930, 275, 300, 50);
    public static Rectangle upgr3button = new Rectangle(930, 350, 300, 50);
    public static Rectangle upgr4button = new Rectangle(930, 425, 300, 50);

    public static bool unlocked3 = false;
    private string name;
    private int count;
    private double price;

    private double upgradestat;

    private Rectangle rectangle;


    public static Rectangle upgr1button = new Rectangle(930, 200, 300, 50);


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

    public static Vector2 ayanoPos = Store.position1.Position;
 
    //Rectangles
    
    public static Rectangle ayanokojiRect = new Rectangle(ayanoPos, 250, 250);
    public static Rectangle tojiRect = new Rectangle(Store.position2.Position, 250, 250);
    public static Rectangle akazaRect = new Rectangle(Store.position3.Position, 250, 250);
    public static Rectangle yoruichiRect = new Rectangle(Store.position4.Position, 250, 250);
    public static Rectangle madaraRect = new Rectangle(Store.position5.Position, 250, 250);
    public static Rectangle jotaroRect = new Rectangle(Store.position6.Position, 250, 250);
    public static Rectangle saitamaRect = new Rectangle(Store.specialPosition.Position, 250, 550);

    //Textures

    public static Texture2D ayanokojiTexture = Raylib.LoadTexture(@"AyanokojiSprite.png");
    public static Texture2D tojiTexture = Raylib.LoadTexture(@"TojiSprite.png");
    public static Texture2D madaraTexture = Raylib.LoadTexture(@"MadaraSprite.png");
    public static Texture2D akazaTexture = Raylib.LoadTexture(@"AkazaSprite.png");
    public static Texture2D jotaroTexture = Raylib.LoadTexture(@"JotaroSprite.png");
    public static Texture2D yoruichiTexture = Raylib.LoadTexture(@"YoruichiSprite.png");
    public static Texture2D saitamaTexture = Raylib.LoadTexture(@"SaitamaSpriteBig.png");





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









