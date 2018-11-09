using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKaya : MonoBehaviour {

	public Camera kayaCamera;
	Animator kaya;
	// Use this for initialization
	void Start () {
		kayaCamera = GetComponent<Camera> ();
		kaya = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (kaya.GetBool ("isWalking") == true) {
			kayaCamera.enabled = true;

		}
		
	}
}
