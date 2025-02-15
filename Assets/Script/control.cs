using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
   public void re_start(){

         SceneManager.LoadScene("level1");
   }

   public void star_t()
   {
      SceneManager.LoadScene("Stage");
   }
   public void Main_menu()
   {
      SceneManager.LoadScene("startgame");
   }
   public void Level1()
   {
      SceneManager.LoadScene("level1");
   }
   public void Level2()
   {
      SceneManager.LoadScene("level2");
   }
   public void re_start2(){
      SceneManager.LoadScene("Level2");
   }

   public void exitGame(){
      Application.Quit();
   }
}
