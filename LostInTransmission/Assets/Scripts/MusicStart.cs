using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour {

	private GameObject musicStart;

	void Awake() {
		musicStart = GameObject.Find ("Music Start");
		if (musicStart != null) {
			AudioSource[] audioSources = musicStart.GetComponents<AudioSource> ();
			foreach (AudioSource source in audioSources) {
				source.Play ();
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
