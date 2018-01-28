using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumsController : MonoBehaviour {

	public Transform Drums;

	void Start()
	{
		Drums.GetComponent<AudioSource>().volume = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		Drums.GetComponent<FadeIn>().fadeIn = true;
	}

}