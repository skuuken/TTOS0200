using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    /*Alla olevassa esimerkissä käyttäjältä kysytään yksi luku väliltä 1-21.
     * Luku tarkistetaan että se on annetulla välillä. Jollei se ole niin käyttäjälle annetaan ilmoitusasiasta, ja ohjelman suoritus päättyy.
     * Tee ohjelmaan seuraavat muutokset:
     * 1) Muuta ohjelmaa että käyttäjältä kysytään lukua niin kauan että se on annetulta väliltä
     * 2) Tee ohjelmaan muutos että käyttäjä voi pelata niin kauan kunnes hän antaa syötteeksi: X tai exit.
     *  Jos käyttäjä antaa jonkin muun merkkijonon joka ei ole kokonaisluku käyttäjälle näytetään ohje sallituista syötteistä.
     * 3) Tee muutos että myös pöydän korttien arvo arvotaan väliltä 10-21. Näytä arvottu luku tuloksen yhteydessä.
     */

    /// <summary>
    /// A simple example of Blackjack card game
    /// </summary>
  namespace Hello
{
    class BlackJack
    {
        public static void PlayBlackJack()
        {
            int myNumber = 17;
            int theirNumber;
            System.Console.WriteLine("*** BlackJack! ***");
            System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
            theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
            //comparing that given umber is valid
                if (theirNumber < 1 || theirNumber > 21)
            {
                Console.WriteLine("The given number is out of limits, try again.");
            }
            else
            {
                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win.");
                }
                else
                {
                    System.Console.WriteLine("You lose.");
                }
            }
        }
    }
}
 