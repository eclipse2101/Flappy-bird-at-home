using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D flappy;
    float horizontal;
   
      

    // Start is called before the first frame update
    void Start()
    {
        flappy = GetComponent<Rigidbody2D>(); // this gets the 2d rigidbody from an object
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

    
}
