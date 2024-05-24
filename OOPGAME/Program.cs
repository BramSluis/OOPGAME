// See https://aka.ms/new-console-template for more information
using OOPGAME;
using OOPGAME.Objects;





string playerInput = "";
Enemy enemyfirst = new Enemy("Megatron", 20);
Player playerfirst = new Player("Daanos", 100, 100);
Orc orcfirst = new Orc(25, "Clabaleclabala", 150);

List<string> enemylist = new List<string>();



// htyyyyyyyyyyyyyyyhooiiiiiiiiiibraaammmmmmmmm
Console.WriteLine(enemyfirst.GetName() + " has risen from the shadow realm ");
Console.WriteLine(" ");

Gamestate Gamemode = Gamestate.Combat;

while (Gamemode == Gamestate.Combat)
{
    if (enemyfirst.GetHealth() <= 0)
    {
        playerfirst.EarnExp(enemyfirst);
        Console.WriteLine(enemyfirst.GetName() + " has freaking died ");
        Console.WriteLine(" ");
        Console.WriteLine(playerfirst.GetName() + " has earned" + playerfirst.GetExp() + " experience! ");
        Console.WriteLine(" ");
        Console.WriteLine(playerfirst.GetName() + " is now at: " + playerfirst.GetExp() + " experience! ");
        playerfirst.LevelUp();
        enemyfirst = new Enemy("Megatron ", 20);
        Console.WriteLine(enemyfirst.GetName() + " appeared ");
        Console.WriteLine(" ");

    }

    Console.WriteLine("what is your immediate action ");
    Console.WriteLine(" ");

    bool validcmdentered = false;
    while (!validcmdentered)
    {
        playerInput = Console.ReadLine();

        switch (playerInput)
        {
            case "Attack":
                enemyfirst.TakeDamage(playerfirst);
                Console.WriteLine("you hit " + enemyfirst.GetName());
                Console.WriteLine(enemyfirst.GetName() + " took " + playerfirst.GetDamage() + " damage!");
                Console.WriteLine(" ");
                Console.WriteLine(enemyfirst.GetName() + "is now at" + enemyfirst.GetHealth() + "hp ");
                Console.WriteLine(" ");
                validcmdentered = true;
                break;

            case "Heal":
                playerfirst.DoHeal();
                Console.WriteLine($"you healed for {playerfirst.GetHeal()} health ");
                Console.WriteLine(" ");
                Console.WriteLine($"you are now at {playerfirst.GetHealth()} health ");
                Console.WriteLine(" ");
                validcmdentered = true;
                break;



            case "KYS":
                playerfirst.ForceDeath();
                Console.WriteLine("you decided you did not feel like living...");
                Gamemode = Gamestate.Gameover;
                validcmdentered = true;
                break;

            default:
                Console.WriteLine("Command unknown");
                break;
        }
    }
    if (playerfirst.GetHealth() <= 0)
    {
        Console.WriteLine("player has died");
        Gamemode = Gamestate.Gameover;
    }



    if (Gamemode == Gamestate.Gameover)
    {
        Console.WriteLine("Game over");
        break;
    }

    if (enemyfirst.GetDoAttack())
    {
        //playerfirst.Health -= enemyfirst.Damage;
        playerfirst.TakeDamage(enemyfirst);
        Console.WriteLine(playerfirst.GetName() + " took " + enemyfirst.GetDamage() + " damage! ");
        Console.WriteLine(playerfirst.GetName() + " is now at " + playerfirst.GetHealth() + " hp ");
    }
    else if (!enemyfirst.GetDoAttack())
    {
        Console.WriteLine(enemyfirst.GetName() + " has decided not to attack ");
    }
 



}
