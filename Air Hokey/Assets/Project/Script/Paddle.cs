using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public int playerNumber;
    public float speed = 10f;

    private Rigidbody paddleRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        paddleRigidbody = gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal" + playerNumber)* speed;
        float verticalMovement = Input.GetAxis("Vertical" + playerNumber)* speed;
        
        paddleRigidbody.velocity = new Vector3 (horizontalMovement,0,verticalMovement) ;
    }
}
