using System;

namespace Abstract_Inheritance
{
    abstract class Equipment
    {
        public abstract void Equip();

    }
    class Armor : Equipment
    {
        public override void Equip()
        {
            
        }
    }
    class player
    {
        public float playerWallet;
        float playerHealth;
        public player(float wallet, float health)
        {
            playerHealth = health;
            playerWallet = wallet;
        }
    }
    abstract class pickUp
    {
        public abstract void pickSomethingUp(player person);
    }
    class Money : pickUp
    {
        float moneyPickedUp;
        public override void pickSomethingUp(player person)
        {
            person.playerWallet += moneyPickedUp;
        }
        Money(float money)
        {
            moneyPickedUp = money;
            pickSomethingUp();
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            player person = new player(20f, 100f);
        }
    }
}