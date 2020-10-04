using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody rb; 

    public float forwardForce = 20.0f;
    public float horizontalForce = 20.0f;

    public bool moveUp = false;
    public bool moveDown = false;
    public bool moveRight = false;
    public bool moveLeft = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey("up"))
            moveUp = true;
        if (Input.GetKey("down"))
            moveDown = true;
        if (Input.GetKey("left"))
            moveLeft = true;
        if (Input.GetKey("right"))
            moveRight = true;
    }

    void FixedUpdate()
    {
        if(moveUp)
            upMovement();
        if(moveDown)
            downMovement();
        if (moveRight) 
            rightMovement();
        if(moveLeft)
            leftMovement();
        
    }

    void upMovement()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);    
    }

    void downMovement()
    {
        rb.AddForce(0, 0, -0.5f * forwardForce * Time.deltaTime);
    }

    void rightMovement()
    {
        rb.AddForce(horizontalForce * Time.deltaTime, 0, 0);
    }

    void leftMovement()
    {
        rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0);
    }
}
