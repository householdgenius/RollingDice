using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
public override int Roll()
        {
            SmackTalk();
            return new Random().Next(DiceSize) + 1;
        }
        public void SmackTalk()
        {
            string[] insults = {"You Suck","You smell","you are bad at this game", "insult#4"};
            Random insult = new Random();
            int index =insult.Next(insults.Length);
            Console.WriteLine($"{insults[index]}");
        }
    }
}