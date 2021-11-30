using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }

        public override int Roll()
        {
            SmackTalk();
            return new Random().Next(DiceSize) + 1;
        }
        public void SmackTalk()
        {
            Console.WriteLine("You Suck");
        }
        }
 }
 
 