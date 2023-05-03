using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BirdScript : MonoBehaviour
{
    Rigidbody2D flappy;
     float horizontal;
     public bool playerIsStillPlaying; // this variable checks if th layer touched a pipe or not. If the player does a game over screen will pop up and no more pipes will spawn 
      int score = 0;
      public Text scoreUI; 

    // Start is called before the first frame update
    void Start()
    {
        flappy = GetComponent<Rigidbody2D>(); // this gets the 2d rigidbody from an object
        playerIsStillPlaying = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          flappy.AddForce(new Vector2(0,1) * 300);
        }
        //movement
        horizontal = Input.GetAxis("Horizontal");

       
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        
        
        // this cause the the playerIsStillPlaying script to become false and make te pipes stop spawning and the game over screen will pop up
        playerIsStillPlaying = false;
    }    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
                {
                    score = score + 1; 
                    // this will increase the score by 1 if the bird collides with a tag called Points
                    scoreUI.text = score.ToString();
                }
    }
}
