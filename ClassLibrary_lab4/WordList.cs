using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary_lab4
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }

        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\lab4\";

        private List<Word> words;

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            words = new List<Word>();
        }

        public static string[] GetLists()
        {
            string[] lists = Directory.GetFiles(path);
            return lists;
        }

        public static WordList LoadList(string name)
        {

            using (StreamReader s = new StreamReader(path + name + ".dat"))
            {

                string[] languages = s.ReadLine().ToUpper().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                WordList content = new WordList(name, languages);
                while (s.EndOfStream == false)
                {
                    Word word = new Word(s.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                    if (word.Translations.Length > 0)
                    {
                        content.words.Add(word);
                    }
                }

                return content;

            }

        }
        public void Save()
        {
            if (!File.Exists(path + Name + ".dat"))
            {
                using (StreamWriter s = File.CreateText(path + Name + ".dat"))
                {

                    foreach (string language in Languages)
                    {
                        s.Write($"{language.ToUpper()};");
                    }
                    s.Close();
                }
            }
            else if (File.Exists(path + Name + ".dat"))
            {
                using (StreamWriter s = File.CreateText(path + Name + ".dat"))
                {
                    foreach (string language in Languages)
                    {
                        s.Write($"{language.ToUpper()};");
                    }
                    s.WriteLine();
                    foreach (Word word in words)
                    {
                        s.Write('\n');
                        for (int i = 0; i < word.Translations.Length; i++)
                        {
                            if (!string.IsNullOrWhiteSpace(word.Translations[i]))
                            {
                                s.Write($"{word.Translations[i]};");
                            }
                        }
                    }
                    s.Close();
                }
            }
        }
        public void Add(params string[] translations)
        {
            Word word = new Word(translations);
            words.Add(word);
        }

        public bool Remove(int translation, string word)
        {
            Word remover = new Word();
            foreach (Word w in words)
            {
                foreach (string str in w.Translations)
                {
                    try
                    {
                        if (w.Translations[translation] == word)
                        {
                            remover = w;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return false;
                    }
                }
            }
            return words.Remove(remover);
        }

        public int Count()
        {
            return words.Count();
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {

            
            foreach (Word w in words.OrderBy(w => w.Translations[sortByTranslation]))
            {
                showTranslations.Invoke(w.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, words.Count);
            int from = rnd.Next(0, Languages.Length);
            int to = rnd.Next(0, Languages.Length);


            if (from == to)
            {
                from = 0;
                to = 1;
            }
            Word word = new Word(translations: words[r].Translations, fromLanguage: from, toLanguage: to);

            return word;
        }
    }
}
