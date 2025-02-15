using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput2 : MonoBehaviour
{
    public WordManager2 wordManager2;
    void Update()
    {
        foreach(char letter in Input.inputString)
        {
            wordManager2.TypeLetter(letter);
        }
    }
}
