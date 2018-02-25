using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CelloControl : MonoBehaviour {

	public GameObject cello;

	void Awake()
	{
		cello = GameObject.Find ("Cello");

		if (cello != null) {
			cello.GetComponent<AudioSource> ().Play ();
		}
	}

	void Start()
	{		
		if (cello != null) {
			cello.GetComponent<AudioSource> ().volume = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (cello != null) {
			cello.GetComponent<FadeIn> ().fadeIn = true;
		}
	}

}
