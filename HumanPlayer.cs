using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
public override int Roll()
        {
           
            Console.WriteLine("Pick a number between 1-6");
            return Int32.Parse(Console.ReadLine());
        }
    }
}