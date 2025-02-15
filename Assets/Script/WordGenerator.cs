using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    public static string[] wordList = {"respectable", "nonremittal", "presidential", "version", 
 "forecast", "faint", "banner", "piece", "authorise", "perfume",
 "qualification", "symptom", "competition", "prey", "degree", "size", 
 "leftovers", "manual", "stomach", "core", "resist", "achievement", 
 "legend", "goat", "recruit", "franchise", "rape", "fat", "brother", 
 "team", "sailor", "prosecution", "hear", "marble", "pound",
 "executrix", "pasture", "regulation", "accountant", "photograph", 
 "calf", "bow", "suffering", "tolerant", "foot", "curve", "remark", 
 "company", "crossing", "demonstrate",
 "adventure", "grace", "inquiry", "boundary", "illusion", "habit", 
 "loyalty", "crisis", "effort", "treasure", "memory", "desire", 
 "wisdom", "unity", "journey", "heritage", "glory", "fantasy", "vision",
 "method", "climate", "fiction", "emotion", "shadow", "courage", 
 "puzzle", "feather", "passion", "freedom", "gesture", "mystery", 
 "fortune", "patience", "balance", "destiny", "reunion", "silence", 
 "charity", "reason", "struggle", "shelter", "process", "reality", 
 "network", "concept", "fiction", "victory", "harvest", "essence"};

    public static string GetRandomWords(){

        int randomIndex = Random.Range(0,wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;

    }
}
