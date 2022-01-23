using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Manager : MonoBehaviour
{
    // Start is called before the first frame update
   GameObject[] boxSpawner;
    
   public Text scoreText;
   public Text highscoreText;
    void Updatescore()
    {
        
    }
//    int spawnerCount = 0;
    void Start()
    {
        // boxSpawner = GameObject.FindGameObjectsWithTag("SpawnPoints");
        // spawnerCount = boxSpawner.Length;
        // highscoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        // if(ScoreScript.scoreValue > PlayerPrefs.GetInt("Highscore", 0))
        // {
        //     PlayerPrefs.SetInt("Highscore", ScoreScript.scoreValue);
        //     highscoreText.text = ScoreScript.scoreValue.ToString();
        // }
    }
}
