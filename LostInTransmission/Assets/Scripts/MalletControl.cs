using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MalletControl : MonoBehaviour {

	public GameObject mallets;

	void Awake()
	{
		mallets = GameObject.Find ("Mallets");
		if (mallets != null) {
			mallets.GetComponent<AudioSource> ().Play ();
		}
	}

	void Start()
	{
		if (mallets != null) {
			mallets.GetComponent<AudioSource> ().volume = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (mallets != null) {
			mallets.GetComponent<FadeIn> ().fadeIn = true;
		}
	}

}
