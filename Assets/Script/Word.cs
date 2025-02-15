using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;  // The word string
    private int typeIndex;  // Index to track the current typed letter

    public WordDisplay display;  // Reference to the display that shows the word on screen

    // Constructor to initialize word and display
    public Word(string _word, WordDisplay _display)
    {
        if (string.IsNullOrEmpty(_word))
        {
            Debug.LogError("Word cannot be null or empty.");
            return;
        }

        word = _word;
        typeIndex = 0;
        display = _display;
        display.SetWord(word);  // Initialize the display with the word
    }

    // Get the next letter to be typed
    public char GetNextLetter()
    {
        if (typeIndex < word.Length)
        {
            return word[typeIndex];
        }
        return '\0';  // Return null character if no more letters left
    }

    // Type the next letter and update the display
    public void TypeLetter()
    {
        if (typeIndex < word.Length)
        {
            typeIndex++;
            if (display != null)
            {
                display.RemoveLetter();
            }
            else
            {
                Debug.LogWarning("Display is null, cannot update the letter display.");
            }
        }
    }

    // Check if the word has been completely typed
    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            if (display != null)
            {
                display.RemoveWord();
            }
            else if (display == null)
            {
                display.RemoveWord();
            }
            else
            {
                Debug.LogWarning("Display is null, cannot remove word display.");
            }

            display = null; 
        }
        return wordTyped;
    }

    public GameObject wordObj
    {
        get
        {
            if (display != null)
            {
                return display.gameObject;
            }
            return null;
        }
    }
}
