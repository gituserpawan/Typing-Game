using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollider : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other) 
    {

        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Tag matched! Loading level1...");
            SceneManager.LoadScene("level1");
        }
    }
}
