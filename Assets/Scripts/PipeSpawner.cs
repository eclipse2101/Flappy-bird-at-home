using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject regularPipe;
    public GameObject trickPipe;
    public float startingTimer = 2.0f;
    public float repeatingTimer = 3.0f;
    public float trickStartingTimer = 2.0f;
    public float trickRepeatingTimer = 3.0f;
    float topRandomHight = -3.57f;
    float bottomRandomHight = -10.05f;

    BirdScript scriptBird;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", startingTimer, repeatingTimer); // this is for the method/ function used to start running after a certain amount of time and keep looping depond on how long you want it to be like 3 seconds.
        InvokeRepeating("SpawnTrickPipes", trickStartingTimer, trickRepeatingTimer);
        scriptBird = GameObject.Find("bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptBird.playerIsStillPlaying == false)
        {
            CancelInvoke(); 
        }
    }

    void SpawnPipes()
    {
        Instantiate(regularPipe, new Vector2 (62.3f, Random.Range(topRandomHight, bottomRandomHight)), Quaternion.identity); 
    }

    void SpawnTrickPipes()
    {
        Instantiate(trickPipe, new Vector2 (62.3f, Random.Range(topRandomHight, bottomRandomHight)), Quaternion.identity); 
    }
}
