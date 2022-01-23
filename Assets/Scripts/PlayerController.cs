using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    public float speed = 25f;
    
    public Rigidbody2D rb;

    public float mapWidth = 30f;
    public float slowness = 10f;


    public int highScore;
     Canvas CanvasObject;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();
        // GameOverScript(false);
        CanvasObject.GetComponent<Canvas> ().enabled = false;
    }

   void FixedUpdate ()
   {
       float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed ;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

       rb.MovePosition(newPosition);
   }

    void OnCollisionEnter2D(){
        FindObjectOfType<GameManager>().EndGame();
        highScore = ScoreScript.scoreValue;
        // Time.timeScale = 1f/slowness;
        // Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        ScoreScript.scoreValue = 0;
        Time.timeScale = 0;
        // blockPrefab.SetActive(false);
    }

}
