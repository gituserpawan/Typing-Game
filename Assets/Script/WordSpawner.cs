using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject WordPrefab;
    public GameObject EnemyPrefab;
    public Transform wordCanvas;
    public WordDisplay SpawnWord() 
    {
        Vector3 randomPosition = new Vector3(Random.Range(-80.5f,80.5f),80f);
        GameObject wordObj = Instantiate(WordPrefab,randomPosition,Quaternion.identity,wordCanvas);
        GameObject enemyObj = Instantiate(EnemyPrefab, randomPosition, Quaternion.identity, wordObj.transform);

        //enemyObj.transform.localPosition = Vector3(40f,40f,0f);
        enemyObj.transform.localScale = new Vector3(250f, 250f, 0f);



        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay; 
    }

}
