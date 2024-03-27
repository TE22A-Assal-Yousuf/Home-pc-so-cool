using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Damage
{
    Enemy enemy = new Enemy();
    Player player = new Player();
    public static double points = 20;
    public static double gems = 500;



    Vector2 mousePos = Raylib.GetMousePosition();
    public static float autodamagedelay = 1;
    public static Font MinecraftFont = Raylib.LoadFont("Minecraft.ttf");
    public static Font MinecrafterFont = Raylib.LoadFont("Minecrafter.Reg.ttf");
    public static Font NeonGlowFont = Raylib.LoadFont("Neon Glow.ttf");


    public void Hit()
    {

        if (Raylib.CheckCollisionPointRec(mousePos, Enemy.enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                points += Player.playerDamege;

            }

        }
    }
    public void update()
    {

        autodamagedelay -= Raylib.GetFrameTime();

        if (autodamagedelay <= 0)
        {

            autodamagedelay = 1;

            points += Player.autoDamage;

        }

            
    }
    public void Draw()
    {
        

    }

}
