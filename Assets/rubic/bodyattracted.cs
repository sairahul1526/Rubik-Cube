using UnityEngine;
using System.Collections;

public class bodyattracted : MonoBehaviour {
	public attractor a;


	// Use this for initialization
	void Start () {
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		rigidbody.useGravity = false;

	}
	
	// Update is called once per frame
	void Update () {
		a.attract (transform);
	}
}
