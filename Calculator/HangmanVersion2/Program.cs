namespace HangmanVersion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome in HangMan game!");
            //Console.WriteLine("Press 'Esc' key to exit the game!");

            while (true)
            {
                var guessedWord = new WordDatabase().GetRandomWord();
                var hangMan = new HangMan();

                //var readKey = Console.ReadKey().Key;
                //if (readKey == ConsoleKey.Escape)
                //    break;

                var hiddenWord = string.Empty;
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    hiddenWord = hiddenWord + "_ ";
                }
                List<char> guessedLettersList = new List<char>();
                List<int> indexesOfGuessedLetters = new List<int>();
                while (true)
                {
                    Console.WriteLine($"\n\nGuess a word: {hiddenWord}");
                    char guessedLetter = ' ';
                    Console.WriteLine("Type a letter:");
                    bool flag = true;
                    while (flag)
                    {
                        guessedLetter = Console.ReadKey().KeyChar;
                        if (!guessedLettersList.Contains(guessedLetter))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("\n\nYou already guessed this letter. Try it again. \nType a letter:");
                        }
                    }

                    if (guessedWord.ToLower().Contains(char.ToLower(guessedLetter)))
                    {
                        Console.WriteLine($"\n\nYes. Letter '{guessedLetter}' is in guessed word.");
                        guessedLettersList.Add(guessedLetter);

                        hiddenWord = "";
                        for (int index = 0; index < guessedWord.Length; index++)
                        {
                            if (char.ToLower(guessedWord[index]) == char.ToLower(guessedLetter) || indexesOfGuessedLetters.Contains(index))
                            {
                                indexesOfGuessedLetters.Add(index);
                                hiddenWord = hiddenWord + guessedWord[index] + " ";
                            }
                            else
                            {
                                hiddenWord = hiddenWord + "_ ";
                            }
                        }
                    }
                    else
                    {
                        guessedLettersList.Add(guessedLetter);
                        hangMan.RemoveOneLive();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        hangMan.Draw();
                        Console.ResetColor();
                        Console.WriteLine($"\nNo. Letter '{guessedLetter}' is not in guessed word.");
                        if (hangMan.GameOverCheck())
                        {
                            Console.WriteLine("You lost!");
                            break;
                        }
                        Console.WriteLine($"\nYou have still {hangMan.Lives} lives.");
                    }
                    if (guessedWord == hiddenWord.Replace(" ", ""))
                    {
                        Console.WriteLine($"\nYou won! Guessed word is {guessedWord}");
                        return;
                    }

                    Console.Write("Guessed letters: ");
                    foreach (char letter in guessedLettersList) 
                    {
                        Console.Write($"{letter}, "); 
                    }
                }
            }
            Console.WriteLine("End of game. Bye!");
            Console.ReadKey();
        }
    }
}
