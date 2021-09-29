using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //https://www.tutorialsteacher.com/articles/difference-between-delegate-and-event-csharp
    //An event is a notification sent by an object to signal the occurrence of an action.
    //https://www.tutorialsteacher.com/csharp/csharp-event
    class Events
    {
        public static void Example()
        {
            var player = new Player
            {
                Name = "Player 1",
                Health = 100
            };
            //
            player.OnHealthChange += playerOnHealthChange;
            player.OnHealthChange += playerOnDead;

            player.Health = 10;
            player.Health = 80;
            player.Health = 0;
            player.Health = 180;
        }

        private static void playerOnDead(object sender, int health)
        {
            var player = (Player)sender;
            if (health==0)
            {
                Console.WriteLine($"{player.Name} is  no more alive;");
            }
          
        }

        private static void playerOnHealthChange(object sender, int health)
        {
            var player = (Player)sender;
            if(health>100 || health<0)
            {
                Console.WriteLine("Health is not valid");
            }
            else
            {
                Console.WriteLine($"{player.Name} has {health}% health;");

            }
        }
    }
    class Player
    {
        private int hp;
        public string Name { get; set; }
        public int Health
        {
            get => this.hp;
            set
            {
                
                this.hp = value; 
                this.OnHealthChange?.Invoke(this, this.hp);
            }
        }

        public event EventHandler<int> OnHealthChange;
    }
}
