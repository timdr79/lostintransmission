using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetDefaultMusic : MonoBehaviour {

	public AudioMixerSnapshot Default;
	public AudioMixerSnapshot Win;

	// Use this for initialization
	void Start () {
		Default.TransitionTo (0.1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
