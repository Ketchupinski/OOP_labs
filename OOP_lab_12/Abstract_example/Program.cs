using System;
using System.Diagnostics;
using System.Security.Principal;
namespace Abstract_example
{
    public abstract class Weapon
    {
        public abstract int Damage { get; }
        
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine("Weapon: " + GetType().Name + "\nDamage: " + Damage);
        }
    }

    public class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void GetInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }

    public class Pistol : Weapon
    {
        public override int Damage
        {
            get { return 5; }
        }

        public override void Fire()
        {
            Console.WriteLine("Piu piu piu piu");
        }
    }

    public class Uzi : Weapon
    {
        public override int Damage => 50;

        public override void Fire()
        {
            Console.WriteLine("Trrrrrrrrrrrrrrrr");
        }
    }

    public class Bazuka : Weapon
    {
        public override int Damage
        {
            get { return 100; }
        }

        public override void Fire()
        {
            Console.WriteLine("BOOOOOOOOOOM");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player();

            Weapon[] w = {new Pistol(), new Uzi(), new Bazuka()};

            foreach (var weapon in w)
            { 
                player.Fire(weapon); 
                player.GetInfo(weapon);
            }
        }
    }
}