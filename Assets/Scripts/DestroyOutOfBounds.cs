using System.Security.Cryptography;
//using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float bottomBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy the object when runs beyond the frame
       if(transform.position.z > topBound) {

            Destroy(gameObject);

       }else if (transform.position.z < bottomBound) {

            Debug.Log("Game Over!");
            Destroy(gameObject);

       }
    }
}
