using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BassController : MonoBehaviour {

	private GameObject bass;

	void Awake()
	{
		bass = GameObject.Find("Bass");
		if (bass != null) {
			bass.GetComponent<AudioSource> ().Play ();
		}
	}

	void Start()
	{
		if (bass != null) {
			bass.GetComponent<AudioSource> ().volume = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (bass != null) {
			bass.GetComponent<FadeIn> ().fadeIn = true;
		}
	}

}
