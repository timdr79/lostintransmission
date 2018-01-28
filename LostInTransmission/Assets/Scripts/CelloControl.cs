using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CelloControl : MonoBehaviour {

	public Transform Cello;

	void Start()
	{
		Cello.GetComponent<AudioSource>().volume = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		Cello.GetComponent<FadeIn>().fadeIn = true;
	}

}
