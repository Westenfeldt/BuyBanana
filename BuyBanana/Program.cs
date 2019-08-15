using System;

namespace BuyBanana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til din lokale grønthandler. Vi har bananer, æbler og applesiner");
            Console.WriteLine("Prisen er:");

            Console.WriteLine("Bananer: 2kr");
            Console.WriteLine("Æbler 2,50kr");
            Console.WriteLine("Applensiner: 4");

            Console.WriteLine("Hvor mange bananer vil du have?");
            int antalBanan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor mange æbler vil du have?");
            int antalapple = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor mange applensiner vil du have?");
            int antalorange = Convert.ToInt32(Console.ReadLine());

            if (antalorange < 0 || antalBanan < 0 || antalapple < 0)
            {
                Console.WriteLine("Du kan ikke købe et negativt antal frugter");
            }
            else if (antalapple >= 0 || antalBanan >= 0 || antalorange >= 0)
                {
                    Console.WriteLine("Du vil gerne købe {0} bananer, {1} æbler og {2} applensiner.", antalBanan, antalapple, antalorange);

                    //Beregning

                    double sum;
                    double prisBanan = 2;
                    double prisApple = 2.50;
                    double prisApplensin = 4;

                    sum = antalBanan * prisBanan + antalapple * prisApple + antalorange * prisApplensin;

                    Console.WriteLine("Det bliver {0:N2} kr", sum);
                }
            

            



             






        }
    }
}
