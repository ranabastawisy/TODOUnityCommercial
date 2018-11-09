using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatTODO : MonoBehaviour {


	Animator kaya;
	public GameObject todoBrownie;
	bool isCarried = false;


	// Use this for initialization
	void Start () {
		kaya = GetComponent<Animator> ();
		todoBrownie = GetComponent<GameObject> ();
	}

	void OnCollisionEnter(Collision c){
		
		if (c.gameObject.CompareTag ("eatTODO")) {
//			var Shovel1= Instantiate (todoBrownie, gameObject.FindGameObjectWithTag("eatTODO").transform.parent.position, Quaternion.identity);
//			Shovel1.transform.parent = GameObject.Find("SpawnPoint").transform;
		}
		
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
