using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HornControl : MonoBehaviour {

	public GameObject horn;

	void Awake()
	{
		horn = GameObject.Find ("Horn");
		if (horn != null) {
			horn.GetComponent<AudioSource> ().Play ();
		}
	}

	void Start()
	{
		if (horn != null) {
			horn.GetComponent<AudioSource> ().volume = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (horn != null) {
			horn.GetComponent<FadeIn> ().fadeIn = true;
		}
	}

}
