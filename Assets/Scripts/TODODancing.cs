using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TODODancing : MonoBehaviour {

	public Animator minionBelly;
	public Animator minionSamba;

	bool isBelly = true;
	// Use this for initialization
	void Start () {
		minionBelly = GetComponent<Animator> ();
		minionSamba = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Jump")  && isBelly) {
			minionBelly.SetTrigger ("stopBelly");
			minionSamba.SetTrigger ("playSamba");
			isBelly = false;
		}

		if (Input.GetButton ("Jump") && !isBelly) {
			minionBelly.SetTrigger ("playBelly");
			minionSamba.SetTrigger ("stopSamba");
			isBelly = true;
		}
	}
}
