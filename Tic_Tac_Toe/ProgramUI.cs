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
            int player = 2; // Player 1 Starts
            int input = 0;
            bool inputCorrect = true;

            Intro();


            do //Alternates player turns.
            {
                if (player == 2)
                {
                    player = 1;
                    CharacterAssign(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    CharacterAssign(player, input);
                }

                GameStart();
                turns++;

              
                HorizontalWin();
                VerticalWin();
                DiagonalWin();

                if (turns == 10)
                {
                    Draw();
                }

                do
                {
                    Console.WriteLine("\nReady Player {0}: It's your move!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (BoardSelections[0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (BoardSelections[1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (BoardSelections[2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (BoardSelections[3] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (BoardSelections[4] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (BoardSelections[5] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (BoardSelections[6] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (BoardSelections[7] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (BoardSelections[8] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Whoops, I didn't get that.  \nPlease try again...");
                        inputCorrect = false;
                    }


                } while (!inputCorrect);
            } while (true);




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

            switch (input)
            {
                case 1: BoardSelections[0] = playerCharacter; break;
                case 2: BoardSelections[1] = playerCharacter; break;
                case 3: BoardSelections[2] = playerCharacter; break;
                case 4: BoardSelections[3] = playerCharacter; break;
                case 5: BoardSelections[4] = playerCharacter; break;
                case 6: BoardSelections[5] = playerCharacter; break;
                case 7: BoardSelections[6] = playerCharacter; break;
                case 8: BoardSelections[7] = playerCharacter; break;
                case 9: BoardSelections[8] = playerCharacter; break;
            }


        } //assigns a character to each player
        public static void GameStart()//pass in 'x' or 'o'
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|   {0}   |   {1}   |   {2}   |", BoardSelections[0], BoardSelections[1], BoardSelections[2]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|   {0}   |   {1}   |   {2}   |", BoardSelections[3], BoardSelections[4], BoardSelections[5]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|   {0}   |   {1}   |   {2}   |", BoardSelections[6], BoardSelections[7], BoardSelections[8]);
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("------------------------");
            Console.ReadKey();
          
          
        } //method brings in the game board
        public static void GameRestart() //method for when the game restarts
        {
            char[] BoardSelectionsIntitialized = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            BoardSelections = BoardSelectionsIntitialized;
            GameStart();
            turns = 0;
        }

        public static void HorizontalWin()
        {
            char[] playerCharacter = { 'X', 'O' };

            foreach (char playerSignature in playerCharacter)
            {
                if (((BoardSelections[0] == playerSignature) && (BoardSelections[1] == playerSignature) && (BoardSelections[2] == playerSignature))
                    || ((BoardSelections[3] == playerSignature) && (BoardSelections[4] == playerSignature) && (BoardSelections[5] == playerSignature))
                    || ((BoardSelections[6] == playerSignature) && (BoardSelections[7] == playerSignature) && (BoardSelections[8] == playerSignature)))
                {
                    Console.Clear();
                    if (playerSignature == 'X')
                    {
                        Console.WriteLine("Congratulations Player 2.\n You have won Tic Tac Toe!");

                    }
                    else if (playerSignature == 'O')
                    {
                        Console.WriteLine("Congratulations Player 1.\nYou have won Tic Tac Toe! ");

                    }
                    Console.WriteLine("Press any key to restart the game...");
                    Console.ReadKey();
                    GameRestart();

                }
            }
        }

        public static void VerticalWin()
        {
            char[] playerCharacter = { 'X', 'O' };

            foreach (char playerSignature in playerCharacter)
            {
                if (((BoardSelections[0] == playerSignature) && (BoardSelections[3] == playerSignature) && (BoardSelections[6] == playerSignature))
                    || ((BoardSelections[1] == playerSignature) && (BoardSelections[4] == playerSignature) && (BoardSelections[7] == playerSignature))
                    || ((BoardSelections[2] == playerSignature) && (BoardSelections[5] == playerSignature) && (BoardSelections[8] == playerSignature)))
                {
                    Console.Clear();
                    if (playerSignature == 'X')
                    {
                        Console.WriteLine("Congratulations Player 2.\n You have won Tic Tac Toe!");

                    }
                    else if (playerSignature == 'O')
                    {
                        Console.WriteLine("Congratulations Player 1.\nYou have won Tic Tac Toe! ");

                    }
                    Console.WriteLine("Press any key to restart the game...");
                    Console.ReadKey();
                    GameRestart();
                }
            }
        }

        public static void DiagonalWin()
        {
            char[] playerCharacter = { 'X', 'O' };
            foreach(char playerSignature in playerCharacter)
            {
                if(((BoardSelections[0] == playerSignature) && (BoardSelections[4] == playerSignature) && (BoardSelections[8] == playerSignature))
                    || ((BoardSelections[6] == playerSignature) && (BoardSelections[4] == playerSignature) && (BoardSelections[2] == playerSignature)))
                {
                    if(playerSignature == 'X')
                    {
                        Console.WriteLine("Congratulations Player 2. \nYou have won Tic Tac Toe!");

                    }
                    else if(playerSignature == 'O')
                    {
                        Console.WriteLine("Congratulations Player 1. \nYou have won Tic Tac Toe!");
                    }
                    Console.WriteLine("Press any key to restart the game...");
                    Console.ReadKey();
                    GameRestart();
                    
                }
            }
        }
        public static void Draw()
        {
            Console.WriteLine("Looks like this one is a draw.. press any key to restart the game...");
            Console.ReadKey();
            GameRestart();
        }
    }
}

        

