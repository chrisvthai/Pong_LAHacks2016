using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    [SerializeField]
    float forceValue = 4.5f;
    
    [SerializeField]
    bool isSecondBall;

    Rigidbody myBody;

	// Use this for initialization
	void Start () {
       
	}
	
   public  void initialize()
    {
        if (!isSecondBall)
        {
            myBody = GetComponent<Rigidbody>();
            myBody.AddForce(new Vector3(forceValue * 20, 0, forceValue * 50));
        }
        else
        {
            myBody = GetComponent<Rigidbody>();
            myBody.AddForce(new Vector3(forceValue * 20, 0, -forceValue * 50));
        }
    }

    public void Reset()
    {
        if (!isSecondBall)
        {
            myBody.velocity = Vector3.zero;
            transform.position = new Vector3(0, 0, -10);
        }

        if (isSecondBall)
        {
            myBody.velocity = Vector3.zero;
            transform.position = new Vector3(0, 0, 10);
        }
        
      
    }

 
	// Update is called once per frame
	void Update () {
	
	}
}
