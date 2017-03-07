using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Transform myTransform; 

	// Use this for initialization
	void Start () {
		myTransform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		myTransform.eulerAngles = Vector3.zero;
	}
}
