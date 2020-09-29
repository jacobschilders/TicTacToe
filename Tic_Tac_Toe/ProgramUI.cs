using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tic_Tac_Toe
{
    public class ProgramUI 
    {
        public void Run()
        {
            Intro();
            GameStart();
           


        }

        //set up
        public static char playerCharacter = ' ';
        static int turns = 0; //when turns ==10 game is a draw
        static char[] BoardSelections = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //input storage
      
        
     

       
        //----------------------------------------------------------------------------//
        //PlayerOne playerOne = new PlayerOne();
        //PlayerTwo playerTwo = new PlayerTwo();
        //Game game = new Game();

        //private void Menu()
        //{
        //    while (playerOne.isWinner == false || playerTwo.isWinner == false)
        //    {
        //        Console.WriteLine("Welcome to Tic-Tac-Toe");
        //        Console.WriteLine("Player One, please choose from the following options: \n");

        //        int place = 1;
        //        foreach (var option in game.Moves)
        //        {
        //            Console.WriteLine($"{place}) {option}");
        //            place++;
        //        }
        //        int userInput = Convert.ToInt32(Console.ReadLine());

        //        switch (userInput)
        //        {
        //            case 1:
        //                //here
        //                break;
        //            case 2:
        //                //here
        //                break;
        //            case 3:
        //                //here
        //                break;
        //            case 4:
        //                //here
        //                break;
        //            case 5:
        //                //here
        //                break;
        //            case 6:
        //                //here
        //                break;
        //            case 7:
        //                //here
        //                break;
        //            case 8:
        //                //here
        //                break;
        //            case 9:
        //                //here
        //                break;
        //        }
        //    }
        //}
        //-----------------------------------------------------------------------------//
        public static void Intro()
        {
         
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Player one = O and Player two = X");
            Console.WriteLine("The first player to match three of their characters in a row win the game!");
            Console.WriteLine("Press any key to begin!");
            Console.ReadKey();
        } //intro method
        public static void CharacterAssign(int player, int input)
        {
            if (player == 1) playerCharacter = 'X';
            else if (player == 2) playerCharacter = 'O';

        } //assigns a character to each player
        public static void GameStart( )//pass in 'x' or 'o'
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|    {0} |   {1} |   {2} |", BoardSelections[0], BoardSelections[1], BoardSelections[2]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|    {0} |   {1} |   {2} |", BoardSelections[3], BoardSelections[4], BoardSelections[5]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|    {0} |   {1} |   {2} |", BoardSelections[6], BoardSelections[7], BoardSelections[8]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.ReadKey();
            var userinput = int.Parse(Console.ReadLine());
            BoardSelections[userinput] = playerCharacter;
        } //method brings in the game board
        public static void GameRestart() //method for when the game restarts
        {
            char[] BoardSelectionsIntitialized = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            BoardSelections = BoardSelectionsIntitialized;
            GameStart();
            turns = 0;
        }

        //need methods for wins
        ///need method for draw



    }

}