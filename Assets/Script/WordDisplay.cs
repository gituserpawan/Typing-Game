using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WordDisplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float fallspeed = 1f;
    public GameObject enemy;

    private void Update()
    {
        transform.Translate(0f, -fallspeed * Time.deltaTime, 0f);

       if (enemy != null)
        {
            enemy.transform.position = transform.position;
        }
    }

    public void SetWord(string word)
    {
        if (text != null)
        {
            text.text = word;
            text.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("TextMeshProUGUI component is missing!");
        }
    }

    public void RemoveLetter()
    {
        if (text != null && text.text.Length > 0)
        {
            text.text = text.text.Remove(0, 1);  
            text.color = Color.red;  
        }
    }

    public void RemoveWord()
    {
        Destroy(gameObject);  
   

    }
}
