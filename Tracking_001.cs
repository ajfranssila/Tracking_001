using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// Skripti, joka poimii salatusta signaalista stringin, joka on 16 tavua pitkä ja ei sisällä toistuvia merkkejä.
/// </summary>
namespace TrackingGame_001
{
    class Program
    {
        static void Main(string[] args)
        {
            laskepatkat();
            Console.ReadKey();
        }


        public static void laskepatkat()
        {
            int kohta = 0;
            string teksti = System.IO.File.ReadAllText(@"LISÄÄ TIEDOSTO");
            StringBuilder parsittu = new StringBuilder();
            StringBuilder parsittu2 = new StringBuilder();

            while (kohta < teksti.Length -15)
            {
                for (int i = kohta; i < kohta + 16; i++)
                {
                    parsittu.Append(teksti[i]);     
                }
                kohta++;

                if (!OnToistuviaKirjaimia(parsittu.ToString())) 
                {
                    parsittu2.Append(parsittu);
                    parsittu2.Append(" ");
                    
                }
                parsittu.Clear();
            }
            Console.WriteLine(parsittu2);
        }


        public static bool OnToistuviaKirjaimia(string source)
        {
            string kasa = "";
            for (int i = 0; i < source.Length; i++)
            {
                if (kasa.Contains(source[i])) return true;
                else kasa = kasa + source[i];
            }
            return false;
        }
    }
}
