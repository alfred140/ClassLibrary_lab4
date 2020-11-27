using ClassLibrary_lab4;
using System;
using System.IO;
using System.Linq;

namespace Console_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\lab4\";


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"\nFolder created. Lists will be saved in {path} \n");
            }
            string comands = ("Use any of the following parameters:\n" +
            "-lists\n" +
            "-new < list name > < language 1 > < language 2 > .. < langauge n >\n" +
            "-add < list name >\n" +
            "-remove < list name > < language > < word 1 > < word 2 > .. < word n >\n" +
            "-words<listname> < sortByLanguage >\n" +
            "-count < listname >\n" +
            "-practice < listname > \n");

            Console.WriteLine(comands);

            while (run == true)
            {
                string input = Console.ReadLine().ToLower();
                string[] argument = input.Split(' ');
                string cmd = argument[0];
                string listName = "";
                string[] languages = new string[] { };

                try
                {
                    listName = argument[1];
                    languages = argument.Skip(2).ToArray();
                }
                catch (IndexOutOfRangeException) { };


                switch (cmd)
                {
                    case "-lists":
                        if (WordList.GetLists().Length == 0)
                        {
                            Console.WriteLine("No lists avalible");
                        }

                        foreach (string savedList in WordList.GetLists())
                        {
                            Console.WriteLine("".PadRight(10, '.') + Path.GetFileNameWithoutExtension(savedList));
                        }
                        break;


                    case "-new":
                        WordList newList = new WordList(listName, languages);

                        if (languages.Length <= 1)
                        {
                            Console.WriteLine("list aborted, type in two or more languages");
                            break;
                        }
                        newList.Save();

                        Console.WriteLine($"{listName} has been created.\n");

                        goto case "-add";


                    case "-add":
                        if (!File.Exists($"{path + listName}.dat"))
                        {
                            Console.WriteLine("List not found");
                            break;
                        }
                        WordList addWord = WordList.LoadList(listName);
                        string word = " ";

                        Console.WriteLine("Press Enter when line is empty to end -add function\n");
                        while (!string.IsNullOrEmpty(word))
                        {
                            string[] words = new string[addWord.Languages.Length];

                            for (int i = 0; i < addWord.Languages.Length; i++)
                            {
                                Console.WriteLine($"\nAdd word to {addWord.Languages[i]}");
                                word = Console.ReadLine();
                                words[i] = word;

                                if (string.IsNullOrEmpty(word))
                                {
                                    Console.WriteLine($"ending -add function");
                                    addWord.Add(words);
                                    Console.WriteLine($"New words saved to {addWord.Name}\n");
                                    goto EndLoop;
                                }
                            }
                            addWord.Add(words);
                        }
                    EndLoop:;
                        addWord.Save();
                        break;


                    case "-remove":
                        WordList removeWord = WordList.LoadList(listName);

                        int index = 0;
                        string[] inputWords = new string[] { };
                        try
                        {
                            inputWords = languages.Skip(1).ToArray();
                            index = Array.FindIndex(removeWord.Languages, row => row.Contains(languages[0].ToUpper()));
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("input incomplete");
                            break;
                        }


                        if (index < 0)
                        {
                            Console.WriteLine("language not found");
                            break;
                        }
                        for (int i = 0; i < inputWords.Length; i++)
                        {
                            if (removeWord.Remove(index, inputWords[i]) == true)
                            {
                                Console.WriteLine($"-{inputWords[i]} removed");
                            }
                            else
                            {
                                Console.WriteLine($"-{inputWords[i]} was not found in {languages[0]} translations");
                            }
                        }
                        removeWord.Save();
                        break;


                    case "-words":
                        Action<string[]> action = new Action<string[]>(ListViewer);
                        Console.WriteLine();
                        try
                        {
                            WordList wordViewer = WordList.LoadList(listName);
                            int position = 0;

                            for (int i = 0; i < wordViewer.Languages.Length; i++)
                            {
                                Console.Write($"{wordViewer.Languages[i]}".PadRight(15));
                            }
                            Console.WriteLine();


                            if (languages.Length != 0)
                            {
                                position = Array.FindIndex(wordViewer.Languages, row => row.Contains(languages[0].ToUpper()));
                            }
                            wordViewer.List(position, action);
                            Console.WriteLine();
                        }
                        catch
                        {
                            Console.WriteLine("list or language not found");
                        }
                        break;


                    case "-count":
                        try
                        {
                            Console.WriteLine($"{WordList.LoadList(listName).Count()} words in {listName}\n");
                        }
                        catch
                        {
                            Console.WriteLine("list not found");
                        }
                        break;


                    case "-practice":
                        WordList practice = null;
                        try
                        {
                            practice = WordList.LoadList(listName);

                        }
                        catch
                        {
                            Console.WriteLine($"{listName} is empty or was not found");
                            break;
                        }

                        bool practicing = true;
                        Console.WriteLine("press ENTER while space is empty to end practice.");
                        int tries = 0;
                        int corrects = 0;

                        while (practicing)
                        {
                            Word w = null;
                            
                                w = practice.GetWordToPractice();                                                           
                              
                            if(w.Translations.Length < practice.Languages.Length)
                            {                                
                                goto retry;
                            }

                            Console.WriteLine($"\nTranslate the {practice.Languages[w.FromLanguage]} word: ({w.Translations[w.FromLanguage]}) to {practice.Languages[w.ToLanguage]}\n");


                            string answer = Console.ReadLine().ToLower();

                            if (answer == w.Translations[w.ToLanguage].ToLower())
                            {
                                Console.WriteLine("Correct".PadLeft(10));
                                corrects++;
                                tries++;
                            }
                            else if (string.IsNullOrEmpty(answer))
                            {
                                practicing = false;
                            }
                            else
                            {
                                Console.WriteLine("wrong".PadLeft(10));
                                tries++;
                            }
                        retry:;
                        }
                        Console.WriteLine($"correct answers: {corrects} out of {tries}");
                        break;


                    default:
                        Console.WriteLine(comands);
                        break;
                }
            }
        }
        public static void ListViewer(string[] translations)
        {

            for (int i = 0; i < translations.Length; i++)
            {
                Console.Write($"{translations[i]}".PadRight(15));
            }
            Console.WriteLine();

        }
    }
}
