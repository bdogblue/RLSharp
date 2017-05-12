using RLSharp.Core;
using RogueSharp.DiceNotation;

namespace RLSharp.Monsters
{
    public class Goblin : Monster
    {
        public static Goblin Create(int level)
        {
            int health = Dice.Roll("2D4");
            return new Goblin
            {
                Attack = Dice.Roll("1D4") + level / 3,
                AttackChance = Dice.Roll("25D3"),
                Awareness = 10,
                Color = Colors.KoboldColor,
                Defense = Dice.Roll("1D3") + level / 3,
                DefenseChance = Dice.Roll("10D4"),
                Gold = Dice.Roll("6D5"),
                Health = health,
                MaxHealth = health,
                Name = "Goblin",
                Speed = 12,
                Symbol = 'g'
            };
        }
    }
}
