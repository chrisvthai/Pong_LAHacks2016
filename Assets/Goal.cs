using UnityEngine;
using System.Collections;


public class Goal : MonoBehaviour {

    [SerializeField]
    int attackingPlayer; // which player scores into this goal
    [SerializeField]
    GameManager gameMan; // this will hold a reference to the game manager script

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.name == "Ball" || other.transform.name == "Ball2")
        {
            gameMan.GoalScored(attackingPlayer);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
