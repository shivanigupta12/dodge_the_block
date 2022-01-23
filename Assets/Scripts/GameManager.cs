using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public float slowness = 10f;
    public GameOverScript GameOverScript;

   

  public void EndGame(){
      // StartCoroutine(RestartLevel());
      // RestartLevel();
      GameOverScript.Setup(ScoreScript.scoreValue);
  }

//   public string RestartLevel(){
      
//         Time.timeScale = 1f/slowness;
//         Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        // yield return new WaitForSeconds(2f/slowness);

//         Time.timeScale = 1f;
//         Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

      
//   }
}
