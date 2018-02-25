using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumsController : MonoBehaviour {

	public GameObject drums;

	void Awake()
	{
		drums = GameObject.Find ("Drums");
		if (drums != null) {
			drums.GetComponent<AudioSource> ().Play ();
		}
	}

	void Start()
	{
		if (drums != null) {
			drums.GetComponent<AudioSource> ().volume = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (drums != null) {
			drums.GetComponent<FadeIn> ().fadeIn = true;
		}
	}

}