using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
   public float speed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this makes the pipes move
        transform.Translate(Vector2.left * Time.deltaTime * speed); 

        //destroy the pipes off screen
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Pipe Border/ Pipe Despawner"))
        {
           Destroy(gameObject);
        }
    }
}
