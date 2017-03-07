using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	// Use this for initialization
	private static int count = 0;
	private Rigidbody2D myRigidBody2D;
	public ScoreManager scoreManager;

	void Start () {
		Debug.Log("start");
		myRigidBody2D = this.GetComponent<Rigidbody2D> ();
	}

	public float UFOSpeed;
	public float forceValue;

	// Update is called once per frame
	void Update () {
		//Debug.Log("Update: " + count++);

		if ( Input.GetKey (KeyCode.W) ) {
			myRigidBody2D.AddForce(new Vector2 (0, UFOSpeed));
		}	

		if ( Input.GetKey (KeyCode.S) ) {
			myRigidBody2D.AddForce(new Vector2 (0, -UFOSpeed));
		}	

		if ( Input.GetKey (KeyCode.A) ) {
			myRigidBody2D.AddForce(new Vector2 (-UFOSpeed, 0));
		}	

		if ( Input.GetKey (KeyCode.D) ) {
			myRigidBody2D.AddForce(new Vector2 (UFOSpeed, 0));
		}	
	}

	void OnTriggerEnter2D(Collider2D other)  
	{ 
		scoreManager.AddScore(100);
		other.gameObject.SetActive (false); 
	} 
}
