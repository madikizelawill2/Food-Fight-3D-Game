//using System.Threading.Tasks.Dataflow;
//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
    public float speed = 10.0f; 
    public float xBoundry = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    
        if (transform.position.x < -xBoundry){
            transform.position = new Vector3(-xBoundry, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBoundry){
            transform.position = new Vector3(xBoundry, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
