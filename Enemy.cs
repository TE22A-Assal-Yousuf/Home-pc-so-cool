using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{

    static int enemyPosX = 540;
    static int enemyPosoY = 330;
    //enemy
    public static Rectangle enemyRect = new Rectangle(enemyPosX, enemyPosoY, 256, 256);

    
    public static Texture2D emntexture = Raylib.LoadTexture(@"Balltexture.png");
    //points

    //font 





    public void Draw()
    {

        //enemy/cllicky

        Raylib.DrawRectangleRec(enemyRect, Color.Blank);
        Raylib.DrawTexture(emntexture, (int)enemyRect.X, (int)enemyRect.Y, Color.White );

        //points stuff
        

        

    }
    
   

}