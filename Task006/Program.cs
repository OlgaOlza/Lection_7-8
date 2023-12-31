﻿// В машинном алфавите есть четыре буквы "а", "и",
// "с", "в". Покажите все слова, состоящие из Т букв,
// которые можно построить из букв этого алфавита 

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.Write($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);