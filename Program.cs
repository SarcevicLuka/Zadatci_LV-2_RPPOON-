using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_LV2_RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Zadatak 1.
            DiceRoller diceRoller=new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> resultsOfRolls = diceRoller.GetRollingResults();
            foreach(int result in resultsOfRolls)
            {
                Console.WriteLine(result);
            }*/


            /*Zadatak 2.
            DiceRoller diceRoller = new DiceRoller();     
            Random randomGenerator = new Random();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6,randomGenerator);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> resultsOfRolls = diceRoller.GetRollingResults();
            foreach (int result in resultsOfRolls)
            {
                Console.WriteLine(result);
            }*/


            /*Zadatak 3.
            DiceRoller diceRoller = new DiceRoller();
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> resultsOfRolls = diceRoller.GetRollingResults();
            foreach (int result in resultsOfRolls)
            {
                Console.WriteLine(result);
            }*/

            /*Zadatak 4. 
            ConsoleLogger consoleLogger = new ConsoleLogger();
            DiceRoller diceRoller = new DiceRoller(consoleLogger);
            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            diceRoller.LogRollingResults();*/
        }
    }
}
