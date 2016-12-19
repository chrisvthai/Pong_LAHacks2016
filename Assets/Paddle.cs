using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    [SerializeField]
   bool isPlayerTwo;
   [SerializeField]
   float speed = 0.3f;       // how far the paddle moves per frame
   Transform myTransform;    // reference to the object's transform

    int direction = 0;
    float previousPositionX;
   // Use this for initialization
   void Start () {
       myTransform = transform;
        previousPositionX = myTransform.position.x;
   }
     
   // FixedUpdate is called once per physics tick/frame
   void FixedUpdate () {
       if (Input.GetKey("escape")) //Escape key = quit game
            Application.Quit();
       // first decide if this is player 1 or player 2 so we know what keys to listen for
       if (isPlayerTwo)
       {
            if (Input.GetKey("i"))
                MoveUp();
            else if (Input.GetKey("k"))
                MoveDown();
            else if (Input.GetKey("j"))
                MoveLeft();
            else if (Input.GetKey("l"))
                MoveRight();
       }
       else // if not player 2 it must be player 1
       {
            if (Input.GetKey("w"))
                MoveUp();
            else if (Input.GetKey("s"))
                MoveDown();
            else if (Input.GetKey("a"))
                MoveLeft();
            else if (Input.GetKey("d"))
                MoveRight();
       }

        if (previousPositionX > myTransform.position.x) direction = -1;
        else if (previousPositionX < myTransform.position.x) direction = 1;
        else direction = 0;
    }

    public void Reset()
    {
        if (isPlayerTwo) transform.position = new Vector3(0, 0, 15);
        else transform.position = new Vector3(0, 0, -15);
    }
 
   // move the player's paddle up by an amount determined by 'speed'
   void MoveUp()
   {
       myTransform.position = new Vector3(myTransform.position.x - speed, myTransform.position.y, myTransform.position.z);
   }
 
   // move the player's paddle down by an amount determined by 'speed'
   void MoveDown()
   {
       myTransform.position = new Vector3 (myTransform.position.x + speed, myTransform.position.y, myTransform.position.z);            
   }
	
   void MoveLeft()
    {
        myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, myTransform.position.z - speed);
    }

   void MoveRight()
    {
        myTransform.position = new Vector3(myTransform.position.x, myTransform.position.y, myTransform.position.z + speed);
    }
   void LateUpdate()
    {
        previousPositionX = myTransform.position.x;
    }

    
    void OnCollisionExit(Collision other)
    {
        float adjust = 4 * direction;
        other.rigidbody.velocity = new Vector3(other.rigidbody.velocity.x + adjust, other.rigidbody.velocity.y, other.rigidbody.velocity.z);
    }
	
}
