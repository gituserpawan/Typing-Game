using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator2 : MonoBehaviour
{
    public static string[] wordList = {"Journey", "Adventure", "Courage", "Legacy", "Spirit", "Victory", 
 "Challenge", "Insight", "Wisdom", "Glory", "Freedom", "Strength", 
 "Dream", "Victory", "Horizon", "Essence", "Rebirth", "Harmony", 
 "Fortitude", "Pride", "Light", "Balance", "Innovation", "Respect", 
 "Conquer", "Destiny", "Savior", "Trust", "Serenity", "Quest", 
 "Endurance", "Hope", "Valor", "Peace", "Revolution", "Reflection", 
 "Venture", "Pursuit", "Triumph", "Embrace", "Grace", "Empower", 
 "Sacrifice", "Bravery", "Focus", "Wisdom", "Unity", "Purpose", 
 "Determination", "Strength", "Optimism", "Reflection", "Aspire", 
 "Awakening", "Phoenix", "Revolution", "Elation", "Aspiration", 
 "Moment", "Vision", "Clarity", "Pursuit", "Resolution", "Dignity", 
 "Brilliance", "Inspire", "Action", "Motivation", "Path", "Empathy", 
 "Dreams", "Radiance", "Ascend", "Stability", "Resilience", "Endurance", 
 "Unity", "Balance", "Purpose", "Essence", "Serenity", "Harmony", 
 "Optimism", "Belief", "Faith", "Strength", "Gratitude", "Opportunity", 
 "Fortitude", "Determination", "Adventure", "Victory", "Hope", "Renewal", 
 "Passion", "Journey", "Clarity", "Venture", "Ambition", "Determined", 
 "Transformation", "Inspiration", "Focus", "Persistence", "Potential", 
 "Renaissance", "Courageous", "Awareness", "Dreamer", "Resilient", 
 "Innovate", "Ascension", "Brave", "Vibrance", "Unyielding", "Conqueror"};

    public static string GetRandomWords(){

        int randomIndex = Random.Range(0,wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;

    }
}
