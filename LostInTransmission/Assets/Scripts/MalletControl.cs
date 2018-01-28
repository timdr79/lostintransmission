using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MalletControl : MonoBehaviour {

	public Transform Mallets;

	void Start()
	{
		Mallets.GetComponent<AudioSource>().volume = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		Mallets.GetComponent<FadeIn>().fadeIn = true;
	}

}
