using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BassController : MonoBehaviour {

	public Transform Bass;

	void Start()
	{
		Bass.GetComponent<AudioSource>().volume = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		Bass.GetComponent<FadeIn>().fadeIn = true;
	}

}
