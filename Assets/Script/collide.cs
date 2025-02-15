using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class collide : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("enemy"))
        {
            Debug.Log("Tag matched! Loading level1...");
            SceneManager.LoadScene("Gameover");
        }
    }
}