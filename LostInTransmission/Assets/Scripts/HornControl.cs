using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HornControl : MonoBehaviour {

	public Transform Horn;

	void Start()
	{
		Horn.GetComponent<AudioSource>().volume = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		Horn.GetComponent<FadeIn>().fadeIn = true;
	}

}
