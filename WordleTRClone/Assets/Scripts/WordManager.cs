using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WordHolder
{
    public char[] word = new char[5];
}
public class WordManager : MonoBehaviour
{
    public List<WordHolder> wordList = new List<WordHolder>();
    public string currentWord;
    public List<string> wordListString = new List<string>();

    private void Awake()
    {
        currentWord = wordListString[Random.Range(0, wordListString.Count)];
        Converter();
    }
    void Converter()
    {
        foreach (string word in wordListString)
        {
            WordHolder temp = new WordHolder();
            temp.word = word.ToCharArray();
            wordList.Add(temp); 
        }
    }
}
