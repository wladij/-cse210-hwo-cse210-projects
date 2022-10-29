using System;

namespace Unit02
{
    class Program
    {
        static void Main(string[] args)
        {
 
        Player player = new Player();
        Game game = new Game();
  
        do
        {
            Random generador = new Random();
            game.aleatorio = generador.Next(1, 14);

            
            Console.WriteLine("The card is: " + game.aleatorio);
            
            Console.Write("Higher or Lower? [h/l]: ");
            player.introducido = Console.ReadLine();
            game.aleatorio1 = generador.Next(1, 14);
            
            if (game.aleatorio1 > game.aleatorio && player.introducido == "h")
            {
                player.score += 100;
            }
            if (game.aleatorio1 > game.aleatorio && player.introducido == "l")
            {
                player.score  -= 75;
            }
            if (game.aleatorio1 < game.aleatorio && player.introducido == "h")
            {
                player.score -= 75;
            }    
            if (game.aleatorio1 < game.aleatorio && player.introducido == "l")
            {
                player.score += 100;
            }

            Console.WriteLine("Next card was: " + game.aleatorio1);
            Console.WriteLine("Your score is: " + player.score);
            game.playAgain();

            Console.WriteLine("");


            
        }
        while ((player.score > 0) && (game.yesNot == 1));

        
       
        }
    }
    //class game has 3 parameters and a method called playAgain
    public class Game
    {
        public int aleatorio;
        public int aleatorio1;
        
        public int yesNot = 0; 
        public void playAgain (){
            Player player = new Player();
            Console.Write("Play again? [y/n] ");
            player.again = Console.ReadLine();
            if (player.again == "y")
            {
                this.yesNot = 1;
            }else if (player.again == "n")
            {
                this.yesNot = 0;
            }

            Console.WriteLine("");
        }       
    }
    //player class has 3 parameters
    public class Player
    {
        public string again;
        public string introducido;
        public int score = 300;

        
    }
}
