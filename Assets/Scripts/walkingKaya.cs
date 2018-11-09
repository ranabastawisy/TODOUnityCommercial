using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingKaya : MonoBehaviour {

	Animator kaya;
	//public GameObject todoBrownie;
	private float speed = -7.0f;
	private float velocity = 0.5f;
	//private float gravity = 12.0f;
	// Use this for initialization
	void Start () {
		kaya = GetComponent<Animator> ();
		//kaya.transform.Translate (new Vector3 (0.0f, 0.0f, speed));


	}

	void OnCollisionEnter(Collision c){
		print ("tozbrdo");
		if (c.gameObject.CompareTag("eatTODO")) {
			print ("TOz");
			kaya.SetTrigger("stopKaya");
			GetComponent<Rigidbody> ().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("w")) {
		//	speed = speed * Time.deltaTime;
			kaya.SetTrigger("walkKaya");
			GetComponent<Rigidbody> ().velocity = new Vector3 (0.0f, 0.0f, speed);
//			kaya.transform.Translate (0.0f, 0.0f, speed);

		}
//		if (Input.GetKeyUp ("w")) {
//			kaya.SetTrigger("stopKaya");
//			GetComponent<Rigidbody> ().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
//		}
	


	}
}
