using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public WordManager wordManager;
    public char[] wordInput = new char[5];
    public char[] word = new char[5];

    public List<Rows> rows = new List<Rows>();
    int currentRow = 0;
    int correctCounter = 0;
    int charCounter = 0;

    private void Start()
    {
        word = wordManager.currentWord.ToCharArray();
    }

    public void SubmitWord()
    {
        string checkStr = new string(wordInput);
        if (!wordManager.wordListString.Contains(checkStr))
        {
            Debug.Log("HATALI KELÝME");
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                if (wordInput[i] == '\0')
                {
                    Debug.Log("Kelimeyi tamamla");
                    break;
                }
                else if (word[i]==wordInput[i])
                {
                    rows[currentRow].rowImages[i].sprite = null;
                    rows[currentRow].rowImages[i].color = Color.green;
                    correctCounter++;
                }
                else
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (wordInput[i] == word[j])
                        {
                            rows[currentRow].rowImages[i].sprite = null;
                            rows[currentRow].rowImages[i].color = Color.yellow;
                            break;
                        }
                        else
                        {
                            rows[currentRow].rowImages[i].sprite = null;
                            rows[currentRow].rowImages[i].color = Color.gray;
                        }
                    }
                }
            }
            if (correctCounter >= 5)
            {
                Debug.Log("Oyunu Kazandýn");
                
            }
            else
            {
                correctCounter = 0;
                currentRow++;
                charCounter = 0;
            }
        }
    }
    public void InputChar(string letter)
    {
        if (charCounter < 5)
        {
            wordInput[charCounter] = letter.ToCharArray()[0];
            rows[currentRow].rowTexts[charCounter].text = letter;
            charCounter++;
        }
    }
    public void DeleteChar()
    {
        if (charCounter >= 1)
        {
            wordInput[charCounter - 1] = ' ';
            rows[currentRow].rowTexts[charCounter - 1].text = " ";
            charCounter--;
        }
    }
}
