using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float rotateSpeed;
	
	// Update is called once per frame
	void Update () {
		this.transform.eulerAngles += new Vector3(0, 0, rotateSpeed);
	}

}
