namespace CasinoGuy
{
    internal class Program
    {
        static void Main()
        {
            Guy player = new Guy { Name = "player", Cash = 100 };

            double odds = .75;

            while (true)
            {
                Console.WriteLine($"Welcome to the casino. The odds are {odds}.");
                player.WriteMyInfo();                

                Console.Write("How much do you want to bet: ");
                string? howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int pot))
                {
                    double bob = Random.Shared.NextDouble();
                    if ( bob < odds & player.Cash != 0 )
                    {
                        int cashGiven = pot * 2;
                        player.ReceiveCash(cashGiven);
                        Console.WriteLine($"You Win {cashGiven}");
                    }                    
                    else
                    {
                        int cashGiven = player.GiveCash(pot);
                        Console.WriteLine("Bad luck, You lose.");                        
                    }

                }
                else
                {
                    Console.WriteLine("The house always wins.");
                }
            }

        }
    }
}
