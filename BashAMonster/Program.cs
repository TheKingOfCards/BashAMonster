using System.Runtime.Intrinsics.Arm;
using BashAMonster;

string enemyName;

Player player = new Player();

Console.WriteLine("Choose your name:");
player.Name = Console.ReadLine();
Console.Clear();

Console.WriteLine("Choose your enemys name");
enemyName = Console.ReadLine();
Console.Clear();

Console.WriteLine("Press A to attack the enemy and press L to leave");

while(player.PlayerInput != "l")
{
     
}


Console.ReadLine();