using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayaScriptDancing : MonoBehaviour {

	Animator kaya;
	public AudioSource sambaSong;
	public AudioSource bellySong;

	bool sambaPlay;
	bool bellyPlay;
	bool toogleSongs;
	// Use this for initialization
	void Start () {
		kaya = GetComponent<Animator> ();
		sambaSong = GetComponent<AudioSource> ();
		//sambaPlay = false;
		//bellySong.Play ();
		sambaSong.Play();
		//bellyPlay = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump") && sambaPlay == false ) {
			kaya.SetTrigger ("BellyToSamba");

			//bellySong.Stop ();
			bellySong.enabled = false;
			if (!bellySong.isPlaying) {
				sambaSong.enabled = true;
//				sambaSong.Play ();
			}

			sambaPlay = true;
		//	bellyPlay = false;
		}

		if (Input.GetButton ("Jump") && sambaPlay == true ) {
			kaya.SetTrigger ("SambaToBelly");
//			sambaSong.Stop ();
		//	bellySong.Play ();
		//	bellyPlay = true;
			sambaPlay = false;
		}
	}
}
